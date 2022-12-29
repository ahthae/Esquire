using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Services.Export;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels.AnalysisMode;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public decimal? UserId { get; }
    public DataQueryMessage(string query, decimal? userId = null) : base(query) => UserId = userId;
}

public partial class AnalysisModeViewModel : ViewModelBase
{
    private CancellationTokenSource _cts = new();
    private bool _querying;
    private BusinessUnitsContext _db;
    private IDbContextFactory<BusinessUnitsContext> _dbFactory;
    private ISettingsService _settingsService;
    private readonly CsvExportService _csvExportService;
    private readonly ILogger<AnalysisModeViewModel> _logger;
    [ObservableProperty] private IEnumerable? _data;

    public AnalysisModeViewModel(ILogger<AnalysisModeViewModel> logger,
        ISettingsService settingsService,
        CsvExportService csvExportService,
        IDbContextFactory<BusinessUnitsContext> dbFactory)
    {
        _logger = logger;
        _settingsService = settingsService;
        _csvExportService = csvExportService;
        _dbFactory = dbFactory;
        _db = _dbFactory.CreateDbContext();
        
        _settingsService.PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName == nameof(_settingsService.Settings))
            {
                _logger.LogInformation("Reloading database connection");
                _db.Dispose();
                _db = _dbFactory.CreateDbContext();
            }
        };
    }

    [RelayCommand]
    public async Task ExportData() => await ExportAsync(Data);

    public async Task RunQueryAsync(string? query, decimal? userId = null)
    {
        try
        {
            await QueryAsync(query, userId);
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to query database: {Message}", ex.Message);
            Log($"Failed to query database: {ex.Message}");
        }
    }

    private async Task QueryAsync(string? query, decimal? userId = null)
    {
        if (_querying)
        {
            _cts.Cancel();
            _querying = false;
            _logger.LogInformation("Query cancelled");
            _cts.Dispose();
            _cts = new CancellationTokenSource();
        }
        switch (query)
        {
            case "Business Units":
            {
                _querying = true;
                var task = _db.FunAllBusinessUnitsVs.ToListAsync(_cts.Token); //TODO select
                Data = await task;
                _querying = false;
                break;
            }

            case "Business Unit Organizations":
            {
                _querying = true;
                var task = (from hou in _db.HrOrganizationUnits
                    join haouf in _db.HrAllOrganizationUnitsFs
                        on hou.OrganizationId equals haouf.OrganizationId
                    join houcf in _db.HrOrgUnitClassificationsFs
                            .Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
                        on haouf.OrganizationId equals houcf.OrganizationId
                    select new
                    {
                        hou.OrganizationId,
                        OrgName = hou.Name,
                        haouf.BusinessGroupId,
                        hou.DateTo
                    }).OrderBy(u => u.OrgName).ToListAsync(_cts.Token);
                Data = await task;
                _querying = false;
                break;
            }

            case "All Business Units for This User":
            {
                _querying = true;
                var task = (from fabu in _db.FunAllBusinessUnitsVs
                        join furda in _db.FunUserRoleDataAsgnmnts.Where(furda => furda.ActiveFlag == "Y")
                            on fabu.BuId equals furda.OrgId
                        join pu in _db.PerUsers.Where(pu => pu.ActiveFlag == "Y" && pu.UserId == userId)
                            on furda.UserGuid equals pu.UserGuid
                        join arv in _db.AseRoleVls on furda.RoleName equals
                            arv.Code //TODO arv.Language = userenv('LANG')
                        select new
                        {
                            PERUserName = pu.Username,
                            furda.RoleName,
                            BusinessUnit = fabu.BuName
                        }).Distinct()
                    .OrderBy(u => u.PERUserName)
                    .ThenBy(u => u.BusinessUnit)
                    .ToListAsync(_cts.Token);
                Data = await task;
                _querying = false;
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