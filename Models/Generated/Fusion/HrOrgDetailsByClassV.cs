using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrOrgDetailsByClassV
    {
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public decimal? OrganizationId { get; set; }
        public string? ClassificationCode { get; set; }
        public string? LegislationCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? SequenceNumber { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? OrgInformationContext { get; set; }
        public string? OrgInformation2 { get; set; }
        public string? OrgInformation3 { get; set; }
    }
}
