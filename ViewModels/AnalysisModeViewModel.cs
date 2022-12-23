using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public decimal? UserId { get; init; }
    public DataQueryMessage(string query, decimal? userId = null) : base(query) => UserId = userId;
}
public class ShowUserDialogMessage : AsyncRequestMessage<IEnumerable> { }

public class AnalysisModeViewModel : ViewModelBase
{
    public readonly IServiceProvider ServiceProvider;
    private IEnumerable _data;
    
    public AnalysisModeViewModel(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<DataQueryMessage>(this, (recipient, message) => 
        {
            try
            {
                RunQueryAsync(message.Value, message.UserId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to query database: {ex.Message}");
            }
        });
    }

    public void ShowDatabaseDialog()
    {
        WeakReferenceMessenger.Default.Send<ShowDatabaseSettingsDialogMessage>();
    }

    public IEnumerable Data
    {
        get => _data;
        set => SetProperty(ref _data, value);
    }

    public async Task RunQueryAsync(string query, decimal? userId = null)
    {
        _ = Task.Run(async () =>
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