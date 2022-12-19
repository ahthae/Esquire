using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsmFilterOptionsFilter
    {
        public decimal? FilterOptionFilterId { get; set; }
        public decimal? FilterOptionId { get; set; }
        public decimal? FilterId { get; set; }
        public string? ChildType { get; set; }
        public decimal? DisplaySequence { get; set; }
        public string? DefaultFlag { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? QuickSetupTaskId { get; set; }
        public decimal? QuickSetupTaskListId { get; set; }
        public string? DeliveryReleaseVersion { get; set; }
        public string? AvailableReleaseVersion { get; set; }
        public string? ExpirationReleaseVersion { get; set; }
        public string? SeedDataSource { get; set; }
        public string? AutoEnabledReleaseVersion { get; set; }
        public string? OraSeedSet1 { get; set; }
        public string? OraSeedSet2 { get; set; }
        public string? AvailableFlag { get; set; }
        public string? AutoEnabledFlag { get; set; }
    }
}
