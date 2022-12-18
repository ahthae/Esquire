using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerRolesDnVl
    {
        public decimal? RoleId { get; set; }
        public string? RoleGuid { get; set; }
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? AbstractRole { get; set; }
        public string? JobRole { get; set; }
        public string? DataRole { get; set; }
        public string? ActiveFlag { get; set; }
        public string? RoleCommonName { get; set; }
        public string? MultitenancyCommonName { get; set; }
        public string? RoleDistinguishedName { get; set; }
        public string? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? DelegationAllowed { get; set; }
        public decimal? ExternalId { get; set; }
        public string? ExternalRole { get; set; }
        public string? DutyRole { get; set; }
    }
}
