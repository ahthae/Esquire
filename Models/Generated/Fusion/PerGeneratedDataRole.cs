using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerGeneratedDataRole
    {
        public decimal? GeneratedDataRoleId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? BaseRoleId { get; set; }
        public decimal? DataRoleId { get; set; }
        public string? DataRoleName { get; set; }
        public string? DataRoleDisplayName { get; set; }
        public string? DataRoleDescription { get; set; }
        public string? AppRoleName { get; set; }
        public string? AppRoleDisplayName { get; set; }
        public string? AppRoleDescription { get; set; }
        public string? ModuleId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? DelegationAllowed { get; set; }
    }
}
