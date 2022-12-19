using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class CstCostOrgsV
    {
        public decimal? CostOrgId { get; set; }
        public string? CostOrgName { get; set; }
        public string? CostOrgCode { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? Status { get; set; }
        public decimal? LegalEntityId { get; set; }
    }
}
