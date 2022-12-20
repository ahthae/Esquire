using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Models.Fusion;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels
{
    public partial class AnalysisModeViewModel : ViewModelBase
    {
        private readonly IServiceProvider _serviceProvider;
        [ObservableProperty] private IEnumerable _data;
        [ObservableProperty] private ObservableCollection<FunAllBusinessUnitsV> _businessUnits;
        
        public AnalysisModeViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, HandleDbNavigation);
        }

        private async void HandleDbNavigation(object? recipient, ValueChangedMessage<string> message)
        {
                try
                {
                    FusionContext db = _serviceProvider.GetService<FusionContext>();
                    switch (message.Value)
                    {
                        case "Business Units": Data = await db.FunAllBusinessUnitsVs.ToListAsync(); break;
                        case "Business Unit Organizations":
                            Data = await (
                                from hou in db.HrOrganizationUnits
                                join haouf in db.HrAllOrganizationUnitsFs on hou.OrganizationId equals haouf.OrganizationId
                                join houcf in db.HrOrgUnitClassificationsFs.Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
    
}