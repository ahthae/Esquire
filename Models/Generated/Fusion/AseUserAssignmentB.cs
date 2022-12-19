using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class AseUserAssignmentB
    {
        public decimal? UserAssignmentId { get; set; }
        public string? UserLogin { get; set; }
        public string? UserTypeCode { get; set; }
        public string? UserTypeValue { get; set; }
        public string? UserStatus { get; set; }
        public decimal? DataSyncId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
