using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerPositionSecurityProfile
    {
        public decimal? PositionSecurityProfileId { get; set; }
        public string? ModuleId { get; set; }
        public string? ViewAll { get; set; }
        public string? Name { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? EnabledFlag { get; set; }
        public string? SecureByAor { get; set; }
        public string? Description { get; set; }
        public string? SecureByPositionHierarchy { get; set; }
        public string? PosHierarchyTreeStructCode { get; set; }
        public string? PosHierarchyTreeCode { get; set; }
        public string? TopPosSelection { get; set; }
        public decimal? TopPositionId { get; set; }
        public string? IncludeTopPosition { get; set; }
        public string? SecureByBusinessUnit { get; set; }
        public decimal? BuOrgSecurityProfileId { get; set; }
        public string? SecureByDepartment { get; set; }
        public decimal? DeptOrgSecurityProfileId { get; set; }
        public string? SecureByJob { get; set; }
        public decimal? JobSecurityProfileId { get; set; }
        public string? SecureByLocation { get; set; }
        public decimal? LocSecurityProfileId { get; set; }
        public string? SecureByPositionList { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public string? IncludeFuturePositions { get; set; }
        public string? Sguid { get; set; }
        public string? SeedDataSource { get; set; }
    }
}
