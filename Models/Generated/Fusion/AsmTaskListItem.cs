using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AsmTaskListItem
    {
        public decimal? TaskListItemId { get; set; }
        public string? TaskListItemShortName { get; set; }
        public decimal? TaskListId { get; set; }
        public string? ItemTypeCode { get; set; }
        public decimal? ItemTaskId { get; set; }
        public decimal? ItemTaskListId { get; set; }
        public decimal? DisplaySequence { get; set; }
        public string? MandatoryFlag { get; set; }
        public string? EnabledFlag { get; set; }
        public string? DeepCopyFlag { get; set; }
        public decimal? ApplicationId { get; set; }
        public string? Parameters { get; set; }
        public decimal? EnterpriseId { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
