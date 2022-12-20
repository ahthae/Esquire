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
    public DataQueryMessage(string query) : base(query) { }
}

public class AnalysisModeViewModel : ViewModelBase
{
    private readonly IServiceProvider _serviceProvider;
    private IEnumerable _data;
    
    public AnalysisModeViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<DataQueryMessage>(this, (recipient, message) => { RunQuery(message.Value); });
    }

    public IEnumerable Data
    {
        get => _data;
        set => SetProperty(ref _data, value);
    }

    private async void RunQuery(string query)
    {
        try
        {
            await Task.Run(() => QueryAsync(query));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to query database: {ex.Message}");
        }
    }

    private async Task QueryAsync(string query)
    {
        FusionContext db = _serviceProvider.GetService<FusionContext>();
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
        }
    }
}