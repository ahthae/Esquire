using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Data;
using esquire.Data.Fusion;
using esquire.Services.Export;
using esquire.Services.Repositories;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels.AnalysisMode;

public partial class AnalysisModeViewModel : ViewModelBase
{
    private readonly ILogger<AnalysisModeViewModel> _logger;
    private readonly CsvExportService _csvExportService;

    private readonly IServiceScope _dbScope;
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

    public async Task RunQueryAsync(string? query, UserDto? user)
    {
        try
        {
            await QueryAsync(query, user);
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to query database: {Message}", ex.Message);
            Log($"Failed to query database: {ex.Message}");
        }
    }

    private async Task QueryAsync(string? query, UserDto? user = null)
    {
        switch (query)
        {
            case "Business Units":
            {
                Data = await _businessUnitsRepository.GetBusinessUnitsAsync();
                break;
            }

            case "Business Unit Organizations":
            {
                if (user is null)
                {
                    //TODO
                }
                Data = await _businessUnitsRepository.GetBusinessUnitOrganizationsAsync();
                break;
            }

            case "All Business Units for This User":
            {
                Data = await _businessUnitsRepository.GetBusinessUnitDataSecurityForUser(user);
                break;
            }
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