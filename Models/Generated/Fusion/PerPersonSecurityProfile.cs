using System;
using System.Collections.Generic;

namespace esquire.Models.Fusion
{
    public partial class PerPersonSecurityProfile
    {
        public decimal? PersonSecurityProfileId { get; set; }
        public string? ModuleId { get; set; }
        public string? ViewAll { get; set; }
        public string? Name { get; set; }
        public decimal? BusinessGroupId { get; set; }
        public string? EnabledFlag { get; set; }
        public string? SecureByPersonType { get; set; }
        public string? SecureByMgrHierarchy { get; set; }
        public string? PrimaryAssignmentOnly { get; set; }
        public string? PersonOrAssignmentLevel { get; set; }
        public string? ManagerTypes { get; set; }
        public string? MaxLevelsInHierarchy { get; set; }
        public string? SecureByDepartment { get; set; }
        public decimal? DeptOrgSecurityProfileId { get; set; }
        public string? SecureByBusinessUnit { get; set; }
        public decimal? BuOrgSecurityProfileId { get; set; }
        public string? SecureByLegalEmployer { get; set; }
        public string? SecureByPosition { get; set; }
        public decimal? PositionSecurityProfileId { get; set; }
        public string? SecureByPayroll { get; set; }
        public decimal? PaySecurityProfileId { get; set; }
        public string? SecureByJob { get; set; }
        public decimal? JobSecurityProfileId { get; set; }
        public string? SecureByLocation { get; set; }
        public decimal? LocationSecurityProfileId { get; set; }
        public string? SecureByLdg { get; set; }
        public decimal? LdgSecurityProfileId { get; set; }
        public string? SecureByGrade { get; set; }
        public decimal? GradeSecurityProfileId { get; set; }
        public string? SecureByGlobalNameRange { get; set; }
        public string? GlobalNameRangeStart { get; set; }
        public string? GlobalNameRangeEnd { get; set; }
        public string? SecureIndvAssignment { get; set; }
        public string? SecureByCustomRestriction { get; set; }
        public string? CustomRestrictionText { get; set; }
        public string? AccessToOwnRecord { get; set; }
        public string? IncludeRelatedContacts { get; set; }
        public string? Description { get; set; }
        public string? SecureByAor { get; set; }
        public decimal? ObjectVersionNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateLogin { get; set; }
        public decimal? LegEmpOrgSecProfileId { get; set; }
        public string? EvalMgrHierarchyFor { get; set; }
        public string? IncludeSharedPeopleInfo { get; set; }
        public string? IncludeFuturePersons { get; set; }
        public string? Purpose { get; set; }
        public string? Sguid { get; set; }
        public string? SeedDataSource { get; set; }
        public string? AsgsToEvaluate { get; set; }
        public string? AccessToCandWithOffer { get; set; }
        public string? EnableExclusion { get; set; }
    }
}
