using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class GlCodeCombination
    {
        public DateTime? PDateFrom { get; set; }
        public DateTime? PDateTo { get; set; }
        public decimal? CodeCombinationId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? EndDateActive { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? RevaluationId { get; set; }
        public string? StartDateActive { get; set; }
        public decimal? CreatedByUserId { get; set; }
        public decimal? LastUpdatedByUserId { get; set; }
        public decimal? AlternateCodeCombinationId { get; set; }
    }
}
