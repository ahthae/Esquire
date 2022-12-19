using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerUserRole
    {
        public decimal? UserRoleId { get; set; }
        public decimal? UserId { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? RoleGuid { get; set; }
        public string? MethodCode { get; set; }
        public string? ActiveFlag { get; set; }
        public string? TerminatedFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
    }
}
