using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerGenDataRoleProfile
    {
        public decimal? GenDataRoleProfilesId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? GeneratedDataRoleId { get; set; }
        public string? HrSecuringObject { get; set; }
        public decimal? SecurityProfileId { get; set; }
        public string? ViewAll { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ModuleId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
