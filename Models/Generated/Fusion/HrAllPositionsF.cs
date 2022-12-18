using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrAllPositionsF
    {
        public decimal? PositionId { get; set; }
        public string? CategoryCode { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? BusinessUnitId { get; set; }
        public string? PositionCode { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? OrganizationId { get; set; }
        public decimal? UnionId { get; set; }
        public decimal? CollectiveAgreementId { get; set; }
        public decimal? JobId { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? EntryGradeId { get; set; }
        public decimal? EntryStepId { get; set; }
        public decimal? SupervisorId { get; set; }
        public decimal? SupervisorAssignmentId { get; set; }
        public decimal? GradeLadderId { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public string? ActiveStatus { get; set; }
        public string? HiringStatus { get; set; }
        public string? PositionType { get; set; }
        public string? PermanentTemporaryFlag { get; set; }
        public string? FullPartTime { get; set; }
        public string? Fte { get; set; }
        public decimal? MaxPersons { get; set; }
        public string? StandardWorkingHours { get; set; }
        public string? StandardWorkingFrequency { get; set; }
        public string? WorkingHours { get; set; }
        public string? Frequency { get; set; }
        public string? TimeNormalStart { get; set; }
        public string? TimeNormalFinish { get; set; }
        public string? ProbationPeriod { get; set; }
        public string? ProbationPeriodUnitCd { get; set; }
        public string? BargainingUnitCd { get; set; }
        public string? PositionSynchronizationFlag { get; set; }
        public string? SecurityClearance { get; set; }
        public string? OverlapAllowed { get; set; }
        public string? SeasonalFlag { get; set; }
        public DateTime? SeasonalStartDate { get; set; }
        public DateTime? SeasonalEndDate { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? AssignmentCategory { get; set; }
        public string? CostCenter { get; set; }
        public decimal? DelegatePositionId { get; set; }
        public string? BudgetedPositionFlag { get; set; }
        public string? BudgetAmount { get; set; }
        public string? BudgetAmountCurrency { get; set; }
        public string? FundedByExistingPosition { get; set; }
        public decimal? RequisitionTemplateId { get; set; }
    }
}
