using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerRoleMappingRole
    {
        public decimal? RoleMappingRoleId { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? RoleMappingId { get; set; }
        public string? UseForAutoProvisioningFlag { get; set; }
        public string? SelfRequestableFlag { get; set; }
        public string? RequestableFlag { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
