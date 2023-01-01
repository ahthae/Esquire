using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using esquire.Data.Fusion;
using esquire.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace esquire.Services.Repositories;

public interface IBusinessUnitsRepository
{
    public Task<List<BusinessUnitDto>> GetBusinessUnitsAsync();
}

public partial class BusinessUnitsRepository : IBusinessUnitsRepository
{
    private readonly ILogger<BusinessUnitsRepository> _logger;
    private readonly BusinessUnitsContext _context;
    public BusinessUnitsRepository(ILogger<BusinessUnitsRepository> logger,
        BusinessUnitsContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public async Task<List<BusinessUnitDto>> GetBusinessUnitsAsync()
    {
        return await _context.FunAllBusinessUnitsVs
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