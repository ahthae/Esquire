using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerOrgSecurityProfile
    {
        public decimal? OrgSecurityProfileId { get; set; }
        public string? ModuleId { get; set; }
        public string? ViewAll { get; set; }
        public string? Name { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? EnabledFlag { get; set; }
        public string? SecureByOrgHierarchy { get; set; }
        public string? OrgHierTreeStructCode { get; set; }
        public string? OrgHierTreeCode { get; set; }
        public string? TopOrgSelection { get; set; }
        public decimal? TopOrganizationId { get; set; }
        public string? IncludeTopOrganization { get; set; }
        public string? SecureByLocation { get; set; }
        public decimal? LocSecurityProfileId { get; set; }
        public string? SecureByOrgClass { get; set; }
        public string? SecureByOrgList { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? IncludeFutureOrganizations { get; set; }
        public string? Sguid { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
