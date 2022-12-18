using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsmSvsFilterOption
    {
        public decimal? SvsFilterOptionId { get; set; }
        public string? Status { get; set; }
        public string? FreezeFlag { get; set; }
        public decimal? ScopeValueSetId { get; set; }
        public decimal? FilterOptionId { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
