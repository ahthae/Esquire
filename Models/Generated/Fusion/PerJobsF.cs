using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerJobsF
    {
        public decimal? JobId { get; set; }
        public decimal? ProgressionJobId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string? JobCode { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? SetId { get; set; }
        public decimal? BenchmarkJobId { get; set; }
        public decimal? JobFamilyId { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public string? ActiveStatus { get; set; }
        public string? BenchmarkJobFlag { get; set; }
        public string? ApprovalAuthority { get; set; }
        public string? ManagerLevel { get; set; }
        public string? MedCheckupReq { get; set; }
        public string? CategoryCode { get; set; }
        public string? RegularTemporary { get; set; }
        public string? FullPartTime { get; set; }
        public string? JobFunctionCode { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? GradeLadderId { get; set; }
        public decimal? RequisitionTemplateId { get; set; }
    }
}
