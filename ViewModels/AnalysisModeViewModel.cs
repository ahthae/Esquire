using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class DataQueryMessage : ValueChangedMessage<string>
{
    public string User { get; init; }
    public DataQueryMessage(string query, string? user = null) : base(query) => User = user;
}
public class ShowUserDialogMessage : AsyncRequestMessage<IEnumerable> { }

public class AnalysisModeViewModel : ViewModelBase
{
    public readonly IServiceProvider ServiceProvider;
    private IEnumerable _data;
    
    public AnalysisModeViewModel(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<DataQueryMessage>(this, (recipient, message) => { RunQueryAsync(message.Value, message.User); });
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

    public async Task RunQueryAsync(string query, string? user = null)
    {
        try
        {
            await Task.Run(async () =>
            {
                FusionContext db = ServiceProvider.GetService<FusionContext>();
                switch (query)
                {
                    case "Business Units":
                        Data = await db.FunAllBusinessUnitsVs.ToListAsync();
                        break;
                    
                    case "Business Unit Organizations":
                        Data = await (
                            from hou in db.HrOrganizationUnits
                            join haouf in db.HrAllOrganizationUnitsFs on hou.OrganizationId equals haouf
                                .OrganizationId
                            join houcf in db.HrOrgUnitClassificationsFs.Where(i =>
                                    i.ClassificationCode == "FUN_BUSINESS_UNIT")
                                on haouf.OrganizationId equals houcf.OrganizationId
                            select new
                            {
                                OrganizationId = hou.OrganizationId,
                                OrgName = hou.Name,
                                BusinessGroupId = haouf.BusinessGroupId,
                                DateTo = hou.DateTo
                            }).ToListAsync();
                        break;
                    case "All Business Units for This User":
                        Data = new ArrayList { user };
                        break;
                }
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to query database: {ex.Message}");
        }
    }
}