using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerRoleMapping
    {
        public decimal? RoleMappingId { get; set; }
        public string? AssignmentStatus { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? MappingName { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public decimal? BusinessUnitId { get; set; }
        public decimal? LegalEmployerId { get; set; }
        public decimal? DepartmentId { get; set; }
        public decimal? JobId { get; set; }
        public decimal? PositionId { get; set; }
        public decimal? GradeId { get; set; }
        public decimal? LocationId { get; set; }
        public string? CurrentManagerFlag { get; set; }
        public decimal? UserPersonTypeId { get; set; }
        public string? SystemPersonType { get; set; }
        public decimal? AssignmentStatusTypeId { get; set; }
        public string? AssignmentType { get; set; }
        public string? AllRolesRequestableFlag { get; set; }
        public decimal? ResourceRoleId { get; set; }
        public string? PartyUsageCode { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? ManagerType { get; set; }
        public string? ResponsibilityType { get; set; }
        public string? ContactRole { get; set; }
        public string? RuleType { get; set; }
    }
}
