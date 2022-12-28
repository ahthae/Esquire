using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Services.Export;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels.AnalysisMode;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public decimal? UserId { get; }
    public DataQueryMessage(string query, decimal? userId = null) : base(query) => UserId = userId;
}

public partial class AnalysisModeViewModel : ViewModelBase
{
    private FusionContext _db;
    private readonly CsvExportService _csvExportService;
    private readonly ILogger<AnalysisModeViewModel> _logger;
    [ObservableProperty] private IEnumerable? _data;

    public AnalysisModeViewModel(ILogger<AnalysisModeViewModel> logger,
        ISettingsService settingsService,
        CsvExportService csvExportService,
        FusionContext db)
    {
        _logger = logger;
        _csvExportService = csvExportService;
        _db = db;
        
        settingsService.Settings.PropertyChanged += (object? sender, PropertyChangedEventArgs args) =>
        {
            _db = Ioc.Default.GetService<FusionContext>();
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
            switch (query)
            {
                case "Business Units":
                Data = await _db.FunAllBusinessUnitsVs.ToListAsync(); //TODO select
                    break;

            case "Business Unit Organizations":
                Data = await (from hou in _db.HrOrganizationUnits
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
                              }).OrderBy(u => u.OrgName).ToListAsync();
                break;

            case "All Business Units for This User":
                Data = await (from fabu in _db.FunAllBusinessUnitsVs
                              join furda in _db.FunUserRoleDataAsgnmnts.Where(furda => furda.ActiveFlag == "Y")
                              on fabu.BuId equals furda.OrgId
                              join pu in _db.PerUsers.Where(pu => pu.ActiveFlag == "Y" && pu.UserId == userId)
                              on furda.UserGuid equals pu.UserGuid
                              join arv in _db.AseRoleVls on furda.RoleName equals arv.Code //TODO arv.Language = userenv('LANG')
                              select new
                              {
                                  PERUserName = pu.Username,
                                  furda.RoleName,
                                  BusinessUnit = fabu.BuName
                              }).Distinct()
                                .OrderBy(u => u.PERUserName)
                                .ThenBy(u => u.BusinessUnit)
                                .ToListAsync();
                break;
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