using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AseUserVl
    {
        public decimal? UserId { get; set; }
        public string? UserGuid { get; set; }
        public string? UserLogin { get; set; }
        public decimal? DataSyncId { get; set; }
        public DateTime? UserCreationDate { get; set; }
        public string? LastActivityTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? ObjectVersionNumber { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? Language { get; set; }
        public string? UserDisplayName { get; set; }
        public string? UserDescription { get; set; }
        public string? SourceLang { get; set; }
    }
}
