using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Models.Fusion;
using Microsoft.EntityFrameworkCore;

namespace esquire.ViewModels
{
    public partial class AnalysisModeViewModel : ViewModelBase
    {
        private readonly FusionContext _db;
        [ObservableProperty] private IEnumerable _data;
        [ObservableProperty] private ObservableCollection<FunAllBusinessUnitsV> _businessUnits;
        
        public AnalysisModeViewModel(FusionContext db)
        {
            _db = db;
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, HandleDbNavigation);
        }

        private async void HandleDbNavigation(object? recipient, ValueChangedMessage<string> message)
        {
                try
                {
                    switch (message.Value)
                    {
                        case "Business Units": Data = await _db.FunAllBusinessUnitsVs.ToListAsync(); break;
                        case "Business Unit Organizations":
                            Data = await (
                                from hou in _db.HrOrganizationUnits
                                join haouf in _db.HrAllOrganizationUnitsFs on hou.OrganizationId equals haouf.OrganizationId
                                join houcf in _db.HrOrgUnitClassificationsFs.Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
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
/*
"SELECT DISTINCT hou.ORGANIZATION_ID     ""Organization ID."", " &
    "                hou.NAME                ""Org. Name (Business Unit Name)"", " &
    "                haouf.business_group_id ""Business Group ID."", " &
    "                hou.DATE_TO             ""Org. To Date"" " &
    "FROM FUSION.HR_ORG_UNIT_CLASSIFICATIONS_F HOUCF, " &
    "     FUSION.HR_ALL_ORGANIZATION_UNITS_F   HAOUF, " &
    "     FUSION.HR_ORGANIZATION_UNITS         hou " &
    "WHERE hou.ORGANIZATION_ID       = haouf.ORGANIZATION_ID " &
    "AND   haouf.ORGANIZATION_ID     = houcf.ORGANIZATION_ID " &
    "AND   houcf.CLASSIFICATION_CODE = 'FUN_BUSINESS_UNIT' " &
    "AND   NVL(to_date(HOUCF.effective_end_date, 'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate " &
    "AND   NVL(to_date(HAOUF.effective_end_date, 'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate " &
    "AND   NVL(to_date(hou.DATE_TO,              'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate " &
    "ORDER BY ""Org. Name (Business Unit Name)"" "
*/