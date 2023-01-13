using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Data;
using esquire.Services.Export;
using esquire.Services.Repositories;
using HanumanInstitute.MvvmDialogs;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels.AnalysisMode;

public partial class AnalysisModeViewModel : ViewModelBase
{
    private readonly ILogger<AnalysisModeViewModel> _logger;
    private readonly CsvExportService _csvExportService;
    private readonly IDialogService _dialogService;

    private readonly IBusinessUnitsRepository _businessUnitsRepository;

    [ObservableProperty] private IEnumerable? _data;

    public AnalysisModeViewModel(ILogger<AnalysisModeViewModel> logger,
        CsvExportService csvExportService,
        IBusinessUnitsRepository businessUnitsRepository,
        IDialogService dialogService)
    {
        _logger = logger;
        _csvExportService = csvExportService;
        _dialogService = dialogService;

        _businessUnitsRepository = businessUnitsRepository;
    }

    [RelayCommand]
    public async Task ExportData() => await ExportAsync(Data);

    public async Task QueryBusinessUnitsAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetBusinessUnitsAsync());
    public async Task QueryBusinessUnitOrganizationsAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetBusinessUnitOrganizationsAsync());

    public async Task QueryPrimaryBusinessUnitsAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetPrimaryBusinessUnitsAsync());
    public async Task QueryPrimaryBusinessUnitsForUserAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetPrimaryBusinessUnitsAsync(await ShowUserDialogAsync()));
    
    public async Task QueryAllBusinessUnitsAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetAllBusinessUnitsAsync());
    public async Task QueryAllBusinessUnitsForUserAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetAllBusinessUnitsAsync(await ShowUserDialogAsync()));
    
    public async Task QueryBusinessUnitDataSecurityAsync() => 
        await TryQueryAsync(async () => await _businessUnitsRepository.GetBusinessUnitDataSecurityAsync());
    public async Task QueryBusinessUnitDataSecurityForUserAsync() => await TryQueryAsync(async () => 
        await _businessUnitsRepository.GetBusinessUnitDataSecurityAsync(await ShowUserDialogAsync()));

    private async Task TryQueryAsync<T>(Func<Task<List<T>>> query)
    {
        try
        {
            Data = await query();
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to query database: {Message}", ex.Message);
            SendLogMessage($"Failed to query database: {ex.Message}");
        }
    }
    
    private async Task<UserDto?> ShowUserDialogAsync()
    {
        var dialog = _dialogService.CreateViewModel<UserDialogViewModel>();
        var result = await ShowDialogAsync(dialog);
        return result == true ? dialog.SelectedUser : null;
    }

    private async Task<bool?> ShowDialogAsync(DialogViewModelBase dialog)
    {
        var mainWindowViewModel = (MainWindowViewModel)_dialogService.DialogManager.GetMainWindow().DataContext; //TODO find a better way to get the owning window
        return await _dialogService.ShowDialogAsync(mainWindowViewModel, dialog);
    }
    
    private async Task ExportAsync(IEnumerable? data) //TODO decouple from export implementation
    {
        if (data is null)
        {
            _logger.LogError("CSV export error: no data to export");
            return;
        }
        
        try
        {
            _logger.LogInformation("Exporting to Export/data.csv");
            await _csvExportService.ExportAsync(data, "Export/data.csv");
        }
        catch (Exception ex)
        {
            _logger.LogError("Export error: {Exception}: {Message}", ex.GetType(), ex.Message);
            SendLogMessage($"Export error: {ex.GetType()}: {ex.Message}");
        }
    }
}