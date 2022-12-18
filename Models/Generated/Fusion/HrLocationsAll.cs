using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrLocationsAll
    {
        public string? PDateFrom { get; set; }
        public DateTime? PDateTo { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LocationCode { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? CreatedByUserId { get; set; }
        public decimal? LastUpdatedByUserId { get; set; }
    }
}
