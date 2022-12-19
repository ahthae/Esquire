using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsmTaskListsVl
    {
        public decimal? TaskListId { get; set; }
        public decimal? OrigTaskListId { get; set; }
        public string? TaskListShortName { get; set; }
        public string? HierarchyNumber { get; set; }
        public string? ActivityTypeCode { get; set; }
        public string? FusionRelease { get; set; }
        public string? EnabledFlag { get; set; }
        public string? DeepCopyFlag { get; set; }
        public string? Owner { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? TaskListName { get; set; }
        public string? TaskListDesc { get; set; }
        public decimal? ServiceId { get; set; }
        public string? InContextFlag { get; set; }
        public string? HelpTopicId { get; set; }
        public string? ModuleId { get; set; }
        public string? CopyEnabledFlag { get; set; }
        public string? DeliveryReleaseVersion { get; set; }
        public string? AvailableReleaseVersion { get; set; }
        public string? ExpirationReleaseVersion { get; set; }
    }
}
