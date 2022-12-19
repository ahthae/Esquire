using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AskTasksVl
    {
        public decimal? TaskId { get; set; }
        public string? TaskShortName { get; set; }
        public string? TaskTypeCode { get; set; }
        public string? WireframeUrl { get; set; }
        public string? UiMockupUrl { get; set; }
        public string? AdfTaskFlow { get; set; }
        public string? ProgramName { get; set; }
        public string? EnabledFlag { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDesc { get; set; }
        public string? TestApplicationLocation { get; set; }
        public string? EnterpriseAppShortName { get; set; }
        public decimal? TaskFlowId { get; set; }
        public string? InvocationType { get; set; }
        public string? EssProgramId { get; set; }
        public string? Parameters { get; set; }
        public string? Owner { get; set; }
        public string? ProducerId { get; set; }
        public string? FullWindowUiInvocation { get; set; }
        public string? HelpTopicId { get; set; }
        public string? ModuleShortName { get; set; }
        public string? ModuleId { get; set; }
        public string? Target { get; set; }
        public string? PerformTaskType { get; set; }
        public string? DeliveryReleaseVersion { get; set; }
        public string? AvailableReleaseVersion { get; set; }
        public string? ExpirationReleaseVersion { get; set; }
    }
}
