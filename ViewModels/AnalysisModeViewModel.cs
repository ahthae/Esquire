using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Services;
using esquire.Services.Export;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public decimal? UserId { get; init; }
    public DataQueryMessage(string query, decimal? userId = null) : base(query) => UserId = userId;
}
public class ShowUserDialogMessage : AsyncRequestMessage<IEnumerable> { }

public partial class AnalysisModeViewModel : ViewModelBase
{
    public readonly IServiceProvider ServiceProvider;
    [ObservableProperty] private IEnumerable _data;
    [ObservableProperty] private string? _infoText;
    
    public AnalysisModeViewModel(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<DataQueryMessage>(this, (recipient, message) => RunQuery(message.Value, message.UserId));
    }

    public void ExportData()
    {
        CsvExportService exportService = ServiceProvider.GetService<CsvExportService>();
        if (exportService is not null)
        {
            try
            {
                exportService.Export(_data, "Export/data.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Export error: {ex.GetType()}: {ex.Message}");
            }
        }
    }

    public void ShowDatabaseDialog()
    {
        WeakReferenceMessenger.Default.Send<ShowDatabaseSettingsDialogMessage>();
    }

    public async void RunQuery(string query, decimal? userId = null) //Defined as an async method and not as a lambda to the DataQuerryMessage to catch exceptions
    {
        try
        {
            await RunQueryAsync(query, userId);
        }
        catch (Exception ex)
        {
            InfoText = $"Failed to query database: {ex.Message}";
            Console.WriteLine(InfoText);
        }
    }

    private async Task RunQueryAsync(string query, decimal? userId = null)
    {
        await Task.Run(async () =>
        {
            FusionContext db = ServiceProvider.GetService<FusionContext>();
            switch (query)
            {
                case "Business Units":
                    Data = await db.FunAllBusinessUnitsVs.OrderBy(u => u.BuName).ToListAsync();
                    break;

                case "Business Unit Organizations":
                    Data = await (from hou in db.HrOrganizationUnits
                                  join haouf in db.HrAllOrganizationUnitsFs
                                      on hou.OrganizationId equals haouf.OrganizationId
                                  join houcf in db.HrOrgUnitClassificationsFs
                                                  .Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
                                      on haouf.OrganizationId equals houcf.OrganizationId
                                  select new
                                  {
                                      OrganizationId = hou.OrganizationId,
                                      OrgName = hou.Name,
                                      BusinessGroupId = haouf.BusinessGroupId,
                                      DateTo = hou.DateTo
                                  }).OrderBy(u => u.OrgName).ToListAsync();
                    break;
                
                case "All Business Units for This User":
                    Data = await (from fabu in db.FunAllBusinessUnitsVs
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
                                .ToListAsync();
                    break;
            }
        });
    }
}