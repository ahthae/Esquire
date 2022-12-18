using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndLookupValuesVl
    {
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDateActive { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LookupCode { get; set; }
        public string? LookupType { get; set; }
        public string? Meaning { get; set; }
        public DateTime? StartDateActive { get; set; }
        public decimal? CreatedByUserId { get; set; }
        public decimal? LastUpdatedByUserId { get; set; }
        public decimal? SetId { get; set; }
        public decimal? ViewApplicationId { get; set; }
    }
}
