using System;
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
    public Task<List<BusinessUnitDataSecurityDto>> GetBusinessUnitDataSecurityAsync(UserDto? user);
    public Task<List<PrimaryBusinessUnitDto>> GetPrimaryBusinessUnitsAsync(UserDto? user = null);
    public Task<List<AllBusinessUnitDto>> GetAllBusinessUnitsAsync(UserDto? user = null);
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
            .Where(fabuv => fabuv.DateTo == null ? true : fabuv.DateTo >= DateTime.Now)
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
                .Where(hou => hou.DateTo == null ? true : hou.DateTo >= DateTime.Now)
            join haouf in _context.HrAllOrganizationUnitsFs
                    .Where(haouf => haouf.EffectiveEndDate == null ? true : haouf.EffectiveEndDate >= DateTime.Now)
                on hou.OrganizationId equals haouf.OrganizationId
            join houcf in _context.HrOrgUnitClassificationsFs
                    .Where(houcf => houcf.EffectiveEndDate == null ? true : houcf.EffectiveEndDate >= DateTime.Now)
                    .Where(houcf => houcf.ClassificationCode == "FUN_BUSINESS_UNIT")
                on haouf.OrganizationId equals houcf.OrganizationId
            select new BusinessUnitOrganizationDto
            {
                OrganizationId = hou.OrganizationId,
                Name = hou.Name,
                BusinessGroupId = haouf.BusinessGroupId,
                DateTo = hou.DateTo
            }).Distinct()
            .OrderBy(u => u.Name).ToListAsync();
    }

    public async Task<List<PrimaryBusinessUnitDto>> GetPrimaryBusinessUnitsAsync(UserDto? user = null)
    {
        return await (from houcf in _context.HrOrgUnitClassificationsFs
                .Where(houcf => houcf.EffectiveEndDate == null ? true : houcf.EffectiveEndDate >= DateTime.Now)
                .Where(houcf => houcf.ClassificationCode == "FUN_BUSINESS_UNIT")
            join haouf in _context.HrAllOrganizationUnitsFs
                .Where(haouf => haouf.EffectiveEndDate == null ? true : haouf.EffectiveEndDate >= DateTime.Now) on houcf.OrganizationId equals haouf.OrganizationId
            join hou in _context.HrOrganizationUnits
                .Where(hou => hou.DateTo == null ? true : hou.DateTo >= DateTime.Now) on haouf.OrganizationId equals hou.OrganizationId
            join paam in _context.PerAllAssignmentsMs
                .Where(paam => paam.AssignmentStatusType == "ACTIVE") 
                .Where(paam => paam.AssignmentType == "E") 
                .Where(paam => paam.EffectiveLatestChange == "Y") 
                .Where(paam => paam.PrimaryAssignmentFlag == "Y")
                .Where(paam => paam.PrimaryFlag == "Y") 
                .Where(paam => paam.EffectiveEndDate == null ? true : paam.EffectiveEndDate >= DateTime.Now)
                on hou.OrganizationId equals paam.BusinessUnitId
            join papf in _context.PerAllPeopleFs
                .Where(papf => papf.EffectiveEndDate == null ? true : papf.EffectiveEndDate >= DateTime.Now) on paam.PersonId equals papf.PersonId
            join pu in _context.PerUsers
                .Where(pu => pu.ActiveFlag == "Y")
                .Where(pu => user == null ? true : pu.UserId == user.UserId) 
                .Where(pu => pu.EndDate == null ? true : pu.EndDate >= DateTime.Now)
                on papf.PersonId equals pu.PersonId
            select new PrimaryBusinessUnitDto
            {
                Username = pu.Username,
                OrganizationId = hou.OrganizationId,
                Name = hou.Name,
            }).Distinct()
            .OrderBy(i => i.Username)
            .ThenBy(i => i.Name).ToListAsync();
    }

    public async Task<List<BusinessUnitDataSecurityDto>> GetBusinessUnitDataSecurityAsync(UserDto? user = null)
    {
        return await (from fabu in _context.FunAllBusinessUnitsVs
                    .Where(fabu => fabu.DateTo == null ? true : fabu.DateTo >= DateTime.Now)
                join furda in _context.FunUserRoleDataAsgnmnts
                            // The entire data set is currently null for this field, but TODO
//                        .Where(furda => furda.EndDateActive == null ? true : DateTime.Parse(furda.EndDateActive) >= DateTime.Now) 
                        .Where(furda => furda.ActiveFlag == "Y")
                    on fabu.BuId equals furda.OrgId
                join pu in _context.PerUsers
                        .Where(pu => user == null ? true : pu.UserId == user.UserId)
                        .Where(pu => pu.EndDate == null ? true : pu.EndDate >= DateTime.Now)
                        .Where(pu => pu.ActiveFlag == "Y") 
                    on furda.UserGuid equals pu.UserGuid
                join arv in _context.AseRoleVls
                    .Where(arv => arv.EffectiveEndDate == null ? true : arv.EffectiveEndDate >= DateTime.Now)
                    on furda.RoleName equals arv.Code //TODO arv.Language = userenv('LANG')
                select new BusinessUnitDataSecurityDto
                {
                    Username = pu.Username,
                    RoleName = furda.RoleName,
                    BuName = fabu.BuName
                }).Distinct()
                  .OrderBy(u => u.Username)
                  .ThenBy(u => u.BuName)
                  .ThenBy(u => u.RoleName)
                  .ToListAsync();
    }

    public async Task<List<AllBusinessUnitDto>> GetAllBusinessUnitsAsync(UserDto? user = null)
    {
        return (from pbu in await GetPrimaryBusinessUnitsAsync(user)
                select new AllBusinessUnitDto { Username = pbu.Username, Name = pbu.Name })
            .Union(from buds in await GetBusinessUnitDataSecurityAsync(user)
                select new AllBusinessUnitDto { Username = buds.Username, Name = buds.BuName })
            .DistinctBy(u => u.Name).ToList();
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