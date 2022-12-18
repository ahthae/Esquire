using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsePrivRoleMbr
    {
        public decimal? MembershipId { get; set; }
        public decimal? PrivilegeId { get; set; }
        public decimal? RoleId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? Staged { get; set; }
        public decimal? DataSyncId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
    }
}
