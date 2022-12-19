using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerGradesF
    {
        public decimal? GradeId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? SetId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public decimal? PayScaleId { get; set; }
        public string? StartingStep { get; set; }
        public decimal? CeilingStepId { get; set; }
        public string? GradeCode { get; set; }
        public string? GradeType { get; set; }
        public string? ActiveStatus { get; set; }
        public string? CategoryCode { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
