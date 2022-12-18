using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class FndObjectInstanceSetsVl
    {
        public string? RowId { get; set; }
        public decimal? InstanceSetId { get; set; }
        public string? InstanceSetName { get; set; }
        public decimal? ObjectId { get; set; }
        public string? Predicate { get; set; }
        public string? Filter { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? DisplayShortName { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramTag { get; set; }
        public string? ChangeSinceLastRefresh { get; set; }
    }
}
