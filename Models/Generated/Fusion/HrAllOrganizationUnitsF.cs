using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrAllOrganizationUnitsF
    {
        public decimal? OrganizationId { get; set; }
        public string? ModuleId { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal? ActionOccurrenceId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? LegalEntityId { get; set; }
        public decimal? EstablishmentId { get; set; }
        public string? InternalExternalFlag { get; set; }
        public string? Type { get; set; }
        public string? InternalAddressLine { get; set; }
        public decimal? CostAllocationKeyflexId { get; set; }
        public decimal? LocationId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? OrganizationCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
