using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class HrOrganizationUnit
    {
        public decimal? OrganizationId { get; set; }
        public string? RowId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? CostAllocationKeyflexId { get; set; }
        public decimal? LocationId { get; set; }
        public DateTime? DateFrom { get; set; }
        public string? Name { get; set; }
        public DateTime? DateTo { get; set; }
        public string? InternalExternalFlag { get; set; }
        public string? InternalAddressLine { get; set; }
        public string? Type { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ObjectVersionNumber { get; set; }
    }
}
