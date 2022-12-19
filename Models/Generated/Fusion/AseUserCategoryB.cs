using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AseUserCategoryB
    {
        public decimal? Id { get; set; }
        public string? Code { get; set; }
        public string? NextUrl { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
