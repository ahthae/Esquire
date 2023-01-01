using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using esquire.Data;
using esquire.Data.Fusion;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace esquire.Services.Repositories;

public interface IBusinessUnitsRepository
{
    public Task<List<BusinessUnitDto>> GetBusinessUnitsAsync();
    public Task<List<BusinessUnitOrganizationDto>> GetBusinessUnitOrganizationsAsync();
    public Task<List<BusinessUnitDataSecurityDto>> GetBusinessUnitDataSecurityForUser(UserDto user);
    public Task<List<UserDto>> GetUsersAsync();
}

public partial class BusinessUnitsRepository : IBusinessUnitsRepository
{
    private readonly ILogger<BusinessUnitsRepository> _logger;
    private readonly IServiceScopeFactory _scopeFactory;
    private IServiceScope _scope;
    private BusinessUnitsContext _context;
    
    public BusinessUnitsRepository(ILogger<BusinessUnitsRepository> logger,
        ISettingsService settingsService,
        IServiceScopeFactory scopeFactory)
    {
        _logger = logger;
        
        _scopeFactory = scopeFactory;
        _scope = _scopeFactory.CreateScope();
        
        _context = _scope.ServiceProvider.GetService<BusinessUnitsContext>();
        
        // Recreate DbContext with new connection settings
        settingsService.PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName != nameof(settingsService.Settings)) return;
            _logger.LogInformation("Reloading database connection");
            
            _scope.Dispose();
            _scope = _scopeFactory.CreateScope();
            _context = _scope.ServiceProvider.GetService<BusinessUnitsContext>();
        };
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
    
    public async Task<List<BusinessUnitOrganizationDto>> GetBusinessUnitOrganizationsAsync()
    {
        return await (from hou in _context.HrOrganizationUnits
            join haouf in _context.HrAllOrganizationUnitsFs
                on hou.OrganizationId equals haouf.OrganizationId
            join houcf in _context.HrOrgUnitClassificationsFs
                    .Where(i => i.ClassificationCode == "FUN_BUSINESS_UNIT")
                on haouf.OrganizationId equals houcf.OrganizationId
            select new BusinessUnitOrganizationDto
            {
                OrganizationId = hou.OrganizationId,
                Name = hou.Name,
                BusinessGroupId = haouf.BusinessGroupId,
                DateTo = hou.DateTo
            }).OrderBy(u => u.Name).ToListAsync();
    }

    public async Task<List<BusinessUnitDataSecurityDto>> GetBusinessUnitDataSecurityForUser(UserDto user)
    {
        return await (from fabu in _context.FunAllBusinessUnitsVs
                join furda in _context.FunUserRoleDataAsgnmnts.Where(furda => furda.ActiveFlag == "Y")
                    on fabu.BuId equals furda.OrgId
                join pu in _context.PerUsers.Where(pu => pu.ActiveFlag == "Y" && pu.UserId == user.UserId)
                    on furda.UserGuid equals pu.UserGuid
                join arv in _context.AseRoleVls on furda.RoleName equals
                    arv.Code //TODO arv.Language = userenv('LANG')
                select new BusinessUnitDataSecurityDto()
                {
                    Username = pu.Username,
                    RoleName = furda.RoleName,
                    BuName = fabu.BuName
                }).Distinct()
            .OrderBy(u => u.Username)
            .ThenBy(u => u.BuName)
            .ToListAsync();
    }

    public async Task<List<UserDto>> GetUsersAsync()
    {
        return await _context.PerUsers
            .Where(user => user.ActiveFlag == "Y")
            .Select(u => new UserDto
            {
                Username = u.Username, 
                UserGuid = u.UserGuid,
                UserId = u.UserId
            }).ToListAsync();
    }
}