using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Data;
using esquire.Services.Export;
using esquire.Services.Repositories;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels.AnalysisMode;

public partial class AnalysisModeViewModel : ViewModelBase
{
    private readonly ILogger<AnalysisModeViewModel> _logger;
    private readonly CsvExportService _csvExportService;

    private readonly IBusinessUnitsRepository _businessUnitsRepository;
    
    [ObservableProperty] private IEnumerable? _data;

    public AnalysisModeViewModel(ILogger<AnalysisModeViewModel> logger,
        CsvExportService csvExportService,
        IBusinessUnitsRepository businessUnitsRepository)
    {
        _logger = logger;
        _csvExportService = csvExportService;

        _businessUnitsRepository = businessUnitsRepository;
    }

    [RelayCommand]
    public async Task ExportData() => await ExportAsync(Data);
    
    public async Task QueryBusinessUnitsAsync() => 
        await TryQueryAsync(() => _businessUnitsRepository.GetBusinessUnitsAsync());
    public async Task QueryBusinessUnitOrganizationsAsync() => 
        await TryQueryAsync(() => _businessUnitsRepository.GetBusinessUnitOrganizationsAsync());
    public async Task QueryBusinessUnitDataSecurityForUserAsync(UserDto user) => 
        await TryQueryAsync(() => _businessUnitsRepository.GetBusinessUnitDataSecurityForUser(user));

    private async Task TryQueryAsync<T>(Func<Task<List<T>>> query)
    {
        try
        {
            Data = await query();
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to query database: {Message}", ex.Message);
            Log($"Failed to query database: {ex.Message}");
        }
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
            await _csvExportService.ExportAsync(data, "Export/data.csv");
        }
        catch (Exception ex)
        {
            _logger.LogError("Export error: {Exception}: {Message}", ex.GetType(), ex.Message);
            Log($"Export error: {ex.GetType()}: {ex.Message}");
        }
    }
}