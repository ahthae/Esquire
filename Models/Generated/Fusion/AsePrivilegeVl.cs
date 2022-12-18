using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsePrivilegeVl
    {
        public decimal? PrivilegeId { get; set; }
        public string? Code { get; set; }
        public string? Guid { get; set; }
        public decimal? DataSyncId { get; set; }
        public decimal? AppId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? Language { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? SourceLang { get; set; }
    }
}
