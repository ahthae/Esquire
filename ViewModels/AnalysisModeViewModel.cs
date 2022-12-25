using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Services.Export;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public decimal? UserId { get; init; }
    public DataQueryMessage(string query, decimal? userId = null) : base(query) => UserId = userId;
}

public partial class AnalysisModeViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<object>? _data;
    [ObservableProperty] private string? _infoText;
    
    public AnalysisModeViewModel() { }

    public void ExportData()
    {
        if (Data is null)
        {
            Console.WriteLine("Export error: no data to export");
            return;
        }

        CsvExportService? exportService = App.Current!.Services.GetService<CsvExportService>();
        if (exportService is null)
        {
            Console.WriteLine("Export error: could not find export service");
            return;
        }
        
        try
        {
            exportService.Export(Data, "Export/data.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Export error: {ex.GetType()}: {ex.Message}");
        }
    }

    [RelayCommand]
    public void ShowDatabaseSettingsDialog()
    {
        OpenDialog<DatabaseSettingsDialogViewModel>();
    }

    public async Task RunQueryAsync(string query, decimal? userId = null)
    {
        try
        {
            await QueryAsync(query, userId);
        }
        catch (Exception ex)
        {
            InfoText = $"Failed to query database: {ex.Message}";
            Console.WriteLine(InfoText);
        }
    }

    private async Task QueryAsync(string query, decimal? userId = null)
    {
            FusionContext db = App.Current!.Services.GetService<FusionContext>()!;
            switch (query)
            {
                case "Business Units":
                Data = new ObservableCollection<object>(await db.FunAllBusinessUnitsVs.OrderBy(u => u.BuName).ToListAsync<object>()); //TODO select
                    break;

            case "Business Unit Organizations":
                Data = new ObservableCollection<object>(await (from hou in db.HrOrganizationUnits
                                                               join haouf in db.HrAllOrganizationUnitsFs
                                                                   on hou.OrganizationId equals haouf.OrganizationId
                                                               join houcf in db.HrOrgUnitClassificationsFs
                                                                               .Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
                                                                   on haouf.OrganizationId equals houcf.OrganizationId
                                                               select new
                                                               {
                                                                   hou.OrganizationId,
                                                                   OrgName = hou.Name,
                                                                   haouf.BusinessGroupId,
                                                                   hou.DateTo
                                                               }).OrderBy(u => u.OrgName).ToListAsync());
                break;

            case "All Business Units for This User":
                Data = new ObservableCollection<object>(await (from fabu in db.FunAllBusinessUnitsVs
                                                               join furda in db.FunUserRoleDataAsgnmnts.Where(furda => furda.ActiveFlag == "Y")
                                                                   on fabu.BuId equals furda.OrgId
                                                               join pu in db.PerUsers.Where(pu => pu.ActiveFlag == "Y" && pu.UserId == userId)
                                                                   on furda.UserGuid equals pu.UserGuid
                                                               join arv in db.AseRoleVls on furda.RoleName equals arv.Code //TODO arv.Language = userenv('LANG')
                                                               select new
                                                               {
                                                                   PERUserName = pu.Username,
                                                                   furda.RoleName,
                                                                   BusinessUnit = fabu.BuName

                                                               }).Distinct()
                                                                 .OrderBy(u => u.PERUserName)
                                                                 .OrderBy(u => u.BusinessUnit)
                                                                 .ToListAsync());
                break;
        }
    }
}