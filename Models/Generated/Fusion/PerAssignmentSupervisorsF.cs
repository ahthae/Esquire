using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerAssignmentSupervisorsF
    {
        public decimal? AssignmentSupervisorId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? AssignmentId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? PersonId { get; set; }
        public string? PrimaryFlag { get; set; }
        public decimal? ManagerAssignmentId { get; set; }
        public decimal? ManagerId { get; set; }
        public string? ManagerType { get; set; }
        public string? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? ActionOccurrenceId { get; set; }
        public string? WorkingPercentage { get; set; }
        public DateTime? FreezeStartDate { get; set; }
        public DateTime? FreezeUntilDate { get; set; }
    }
}
