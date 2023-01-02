using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using esquire.Data;
using esquire.Data.Fusion;
using Microsoft.EntityFrameworkCore;

namespace esquire.Queries;

public class BusinessUnitQuery : QueryBase<BusinessUnitDto>
{
    public BusinessUnitQuery(BusinessUnitsContext context) : base(context) { }
    
    public override async Task<IEnumerable<BusinessUnitDto>> GetAsync()
    {
        return await ((BusinessUnitsContext)_context).FunAllBusinessUnitsVs
            .Select(i => new BusinessUnitDto
            {
                BuId = i.BuId,
                BuName = i.BuName,
                BusinessGroupId = i.BusinessGroupId,
                CreationDate = i.CreationDate,
                DateFrom = i.DateFrom,
                DateTo = i.DateTo,
                DefaultCurrencyCode = i.DefaultCurrencyCode,
                DefaultSetId = i.DefaultSetId,
                EnabledForHrFlag = i.EnabledForHrFlag,
                FinBusinessUnitId = i.FinBusinessUnitId,
                LastUpdateDate = i.LastUpdateDate,
                LastUpdateLogin = i.LastUpdateLogin,
                LastUpdatedBy = i.LastUpdatedBy,
                LegalEntityId = i.LegalEntityId,
                LocationId = i.LocationId,
                ManagerId = i.ManagerId,
                PrimaryLedgerId = i.PrimaryLedgerId,
                ProfitCenterFlag = i.ProfitCenterFlag,
                ShortCode = i.ShortCode,
                Status = i.Status
            }).ToListAsync();
    }
}