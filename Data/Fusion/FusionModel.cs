using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using esquire.Models.Fusion;

namespace esquire.Data.Fusion
{
    public partial class FusionContext : DbContext
    {
        public FusionContext()
        {
        }

        public FusionContext(DbContextOptions<FusionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AseApplicationVl> AseApplicationVls { get; set; } = null!;
        public virtual DbSet<AsePermissionVl> AsePermissionVls { get; set; } = null!;
        public virtual DbSet<AsePrivRoleMbr> AsePrivRoleMbrs { get; set; } = null!;
        public virtual DbSet<AsePrivilegeVl> AsePrivilegeVls { get; set; } = null!;
        public virtual DbSet<AseRoleRoleMbr> AseRoleRoleMbrs { get; set; } = null!;
        public virtual DbSet<AseRoleTypeVl> AseRoleTypeVls { get; set; } = null!;
        public virtual DbSet<AseRoleVl> AseRoleVls { get; set; } = null!;
        public virtual DbSet<AseUserAssignmentB> AseUserAssignmentBs { get; set; } = null!;
        public virtual DbSet<AseUserCategoryB> AseUserCategoryBs { get; set; } = null!;
        public virtual DbSet<AseUserLoginInfo> AseUserLoginInfos { get; set; } = null!;
        public virtual DbSet<AseUserRoleMbr> AseUserRoleMbrs { get; set; } = null!;
        public virtual DbSet<AseUserVl> AseUserVls { get; set; } = null!;
        public virtual DbSet<AskApplicationCloud> AskApplicationClouds { get; set; } = null!;
        public virtual DbSet<AskBusinessObjectsVl> AskBusinessObjectsVls { get; set; } = null!;
        public virtual DbSet<AskTasksVl> AskTasksVls { get; set; } = null!;
        public virtual DbSet<AsmFilterOptionsFilter> AsmFilterOptionsFilters { get; set; } = null!;
        public virtual DbSet<AsmFilterOptionsVl> AsmFilterOptionsVls { get; set; } = null!;
        public virtual DbSet<AsmFiltersVl> AsmFiltersVls { get; set; } = null!;
        public virtual DbSet<AsmScope> AsmScopes { get; set; } = null!;
        public virtual DbSet<AsmSvsFilterOption> AsmSvsFilterOptions { get; set; } = null!;
        public virtual DbSet<AsmTaskListItem> AsmTaskListItems { get; set; } = null!;
        public virtual DbSet<AsmTaskListsVl> AsmTaskListsVls { get; set; } = null!;
        public virtual DbSet<CstCostOrgsV> CstCostOrgsVs { get; set; } = null!;
        public virtual DbSet<FaBookControl> FaBookControls { get; set; } = null!;
        public virtual DbSet<FndApplicationVl> FndApplicationVls { get; set; } = null!;
        public virtual DbSet<FndCompiledMenuFunction> FndCompiledMenuFunctions { get; set; } = null!;
        public virtual DbSet<FndFormFunctionsVl> FndFormFunctionsVls { get; set; } = null!;
        public virtual DbSet<FndGrant> FndGrants { get; set; } = null!;
        public virtual DbSet<FndLookupValuesVl> FndLookupValuesVls { get; set; } = null!;
        public virtual DbSet<FndMenu> FndMenus { get; set; } = null!;
        public virtual DbSet<FndMenuEntry> FndMenuEntries { get; set; } = null!;
        public virtual DbSet<FndObjectInstanceSetsVl> FndObjectInstanceSetsVls { get; set; } = null!;
        public virtual DbSet<FndObjectsVl> FndObjectsVls { get; set; } = null!;
        public virtual DbSet<FndSetidSetsVl> FndSetidSetsVls { get; set; } = null!;
        public virtual DbSet<FunAllBusinessUnitsV> FunAllBusinessUnitsVs { get; set; } = null!;
        public virtual DbSet<FunFinBusinessUnitsV> FunFinBusinessUnitsVs { get; set; } = null!;
        public virtual DbSet<FunIntercoOrganization> FunIntercoOrganizations { get; set; } = null!;
        public virtual DbSet<FunUserRoleDataAsgnmnt> FunUserRoleDataAsgnmnts { get; set; } = null!;
        public virtual DbSet<GlAccessSet> GlAccessSets { get; set; } = null!;
        public virtual DbSet<GlCodeCombination> GlCodeCombinations { get; set; } = null!;
        public virtual DbSet<GlLedger> GlLedgers { get; set; } = null!;
        public virtual DbSet<GlLedgerLeV> GlLedgerLeVs { get; set; } = null!;
        public virtual DbSet<HrAllOrganizationUnitsF> HrAllOrganizationUnitsFs { get; set; } = null!;
        public virtual DbSet<HrAllPositionsF> HrAllPositionsFs { get; set; } = null!;
        public virtual DbSet<HrAllPositionsFVl> HrAllPositionsFVls { get; set; } = null!;
        public virtual DbSet<HrLocationsAll> HrLocationsAlls { get; set; } = null!;
        public virtual DbSet<HrLocationsAllFVl> HrLocationsAllFVls { get; set; } = null!;
        public virtual DbSet<HrOperatingUnit> HrOperatingUnits { get; set; } = null!;
        public virtual DbSet<HrOrgDetailsByClassV> HrOrgDetailsByClassVs { get; set; } = null!;
        public virtual DbSet<HrOrgUnitClassificationsF> HrOrgUnitClassificationsFs { get; set; } = null!;
        public virtual DbSet<HrOrganizationUnit> HrOrganizationUnits { get; set; } = null!;
        public virtual DbSet<HrOrganizationV> HrOrganizationVs { get; set; } = null!;
        public virtual DbSet<InvOrgParameter> InvOrgParameters { get; set; } = null!;
        public virtual DbSet<PayFlwSecurityProfile> PayFlwSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PayPaySecurityProfile> PayPaySecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerAllAssignmentsM> PerAllAssignmentsMs { get; set; } = null!;
        public virtual DbSet<PerAllPeopleF> PerAllPeopleFs { get; set; } = null!;
        public virtual DbSet<PerAssignmentSupervisorsF> PerAssignmentSupervisorsFs { get; set; } = null!;
        public virtual DbSet<PerCountrySecurityProfile> PerCountrySecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerDepartment> PerDepartments { get; set; } = null!;
        public virtual DbSet<PerDocTypeSecurityProfile> PerDocTypeSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerGenDataRoleProfile> PerGenDataRoleProfiles { get; set; } = null!;
        public virtual DbSet<PerGeneratedDataRole> PerGeneratedDataRoles { get; set; } = null!;
        public virtual DbSet<PerGradesF> PerGradesFs { get; set; } = null!;
        public virtual DbSet<PerJobsF> PerJobsFs { get; set; } = null!;
        public virtual DbSet<PerLdapUser> PerLdapUsers { get; set; } = null!;
        public virtual DbSet<PerLdgSecurityProfile> PerLdgSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerLegalEmployer> PerLegalEmployers { get; set; } = null!;
        public virtual DbSet<PerLocationDetailsF> PerLocationDetailsFs { get; set; } = null!;
        public virtual DbSet<PerLocationDetailsFVl> PerLocationDetailsFVls { get; set; } = null!;
        public virtual DbSet<PerLocationDetailsX> PerLocationDetailsXes { get; set; } = null!;
        public virtual DbSet<PerOrgSecurityProfile> PerOrgSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerPeriodsOfService> PerPeriodsOfServices { get; set; } = null!;
        public virtual DbSet<PerPersonNamesF> PerPersonNamesFs { get; set; } = null!;
        public virtual DbSet<PerPersonSecurityProfile> PerPersonSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerPersonTypesVl> PerPersonTypesVls { get; set; } = null!;
        public virtual DbSet<PerPositionSecurityProfile> PerPositionSecurityProfiles { get; set; } = null!;
        public virtual DbSet<PerRoleMapping> PerRoleMappings { get; set; } = null!;
        public virtual DbSet<PerRoleMappingRole> PerRoleMappingRoles { get; set; } = null!;
        public virtual DbSet<PerRolesDnVl> PerRolesDnVls { get; set; } = null!;
        public virtual DbSet<PerUser> PerUsers { get; set; } = null!;
        public virtual DbSet<PerUserRole> PerUserRoles { get; set; } = null!;
        public virtual DbSet<RcsMfgParameter> RcsMfgParameters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=SYSTEM;Password=<password>;Data Source=localhost/XEPDB1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<AseApplicationVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_APPLICATION_VL", "FUSION");

                entity.Property(e => e.AppDisplayname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APP_DISPLAYNAME");

                entity.Property(e => e.AppId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APP_ID");

                entity.Property(e => e.AppName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APP_NAME");

                entity.Property(e => e.AppStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APP_STATUS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");
            });

            modelBuilder.Entity<AsePermissionVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_PERMISSION_VL", "FUSION");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.ActionDelimiter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_DELIMITER");

                entity.Property(e => e.AppId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APP_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PermissionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERMISSION_ID");

                entity.Property(e => e.PrivilegeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.ResourceTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESOURCE_TYPE_NAME");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");
            });

            modelBuilder.Entity<AsePrivRoleMbr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_PRIV_ROLE_MBR", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MembershipId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MEMBERSHIP_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PrivilegeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.Staged)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAGED");
            });

            modelBuilder.Entity<AsePrivilegeVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_PRIVILEGE_VL", "FUSION");

                entity.Property(e => e.AppId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APP_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PrivilegeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");
            });

            modelBuilder.Entity<AseRoleRoleMbr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_ROLE_ROLE_MBR", "FUSION");

                entity.Property(e => e.ChildRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CHILD_ROLE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MembershipId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MEMBERSHIP_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ParentRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENT_ROLE_ID");

                entity.Property(e => e.Staged)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAGED");
            });

            modelBuilder.Entity<AseRoleTypeVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_ROLE_TYPE_VL", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RoleTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_TYPE_CODE");

                entity.Property(e => e.RoleTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_TYPE_ID");

                entity.Property(e => e.RoleTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_TYPE_NAME");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");
            });

            modelBuilder.Entity<AseRoleVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_ROLE_VL", "FUSION");

                entity.Property(e => e.AppId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APP_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.IsSeeded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IS_SEEDED");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");

                entity.Property(e => e.RoleTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_TYPE_CODE");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");

                entity.Property(e => e.Staged)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAGED");
            });

            modelBuilder.Entity<AseUserAssignmentB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_USER_ASSIGNMENT_B", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.UserAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ASSIGNMENT_ID");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_LOGIN");

                entity.Property(e => e.UserStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_STATUS");

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_TYPE_CODE");

                entity.Property(e => e.UserTypeValue)
                    .HasColumnType("CLOB")
                    .HasColumnName("USER_TYPE_VALUE");
            });

            modelBuilder.Entity<AseUserCategoryB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_USER_CATEGORY_B", "FUSION");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.NextUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEXT_URL");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");
            });

            modelBuilder.Entity<AseUserLoginInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_USER_LOGIN_INFO", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_LOGIN_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GUID");
            });

            modelBuilder.Entity<AseUserRoleMbr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_USER_ROLE_MBR", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MembershipId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MEMBERSHIP_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.Staged)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAGED");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<AseUserVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASE_USER_VL", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataSyncId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_SYNC_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE");

                entity.Property(e => e.LastActivityTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_ACTIVITY_TIME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SourceLang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LANG");

                entity.Property(e => e.UserCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("USER_CREATION_DATE");

                entity.Property(e => e.UserDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_DESCRIPTION");

                entity.Property(e => e.UserDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_DISPLAY_NAME");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GUID");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_LOGIN");
            });

            modelBuilder.Entity<AskApplicationCloud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASK_APPLICATION_CLOUDS", "FUSION");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_PERSON");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Customer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.DataCenterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_CENTER_ID");

                entity.Property(e => e.DeployedAt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPLOYED_AT");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.EnvironmentTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENVIRONMENT_TYPE_ID");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OvmTemplateId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OVM_TEMPLATE_ID");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Tenant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TENANT");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<AskBusinessObjectsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASK_BUSINESS_OBJECTS_VL", "FUSION");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE");

                entity.Property(e => e.Api)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("API");

                entity.Property(e => e.ApiType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("API_TYPE");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.BusinessAreaId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_AREA_ID");

                entity.Property(e => e.BusinessObjectDesc)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_OBJECT_DESC");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_OBJECT_ID");

                entity.Property(e => e.BusinessObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_OBJECT_NAME");

                entity.Property(e => e.BusinessObjectShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_OBJECT_SHORT_NAME");

                entity.Property(e => e.CommitIfWarningFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMMIT_IF_WARNING_FLAG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataStorageClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATA_STORAGE_CLASS");

                entity.Property(e => e.DenseAttributesFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DENSE_ATTRIBUTES_FLAG");

                entity.Property(e => e.DeploymentDataStore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPLOYMENT_DATA_STORE");

                entity.Property(e => e.EnterpriseAppShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTERPRISE_APP_SHORT_NAME");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_TYPE");

                entity.Property(e => e.ExceptionAction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPTION_ACTION");

                entity.Property(e => e.ExportAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPORT_ALLOWED_FLAG");

                entity.Property(e => e.FilterAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_ALLOWED_FLAG");

                entity.Property(e => e.GenericFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GENERIC_FLAG");

                entity.Property(e => e.HighDataVolume)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIGH_DATA_VOLUME");

                entity.Property(e => e.HighVolumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIGH_VOLUMN_TYPE");

                entity.Property(e => e.HoldSetupTasks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOLD_SETUP_TASKS");

                entity.Property(e => e.ImportPauseFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_PAUSE_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LctEntityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LCT_ENTITY_CODE");

                entity.Property(e => e.LctFile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LCT_FILE");

                entity.Property(e => e.LctLink)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LCT_LINK");

                entity.Property(e => e.LowVolumeRange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOW_VOLUME_RANGE");

                entity.Property(e => e.ManualMigrationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANUAL_MIGRATION_FLAG");

                entity.Property(e => e.Milestone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MILESTONE");

                entity.Property(e => e.MilestoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MILESTONE_CODE");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ModuleShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_SHORT_NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ObsoleteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBSOLETE_FLAG");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.ParentBusinessObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENT_BUSINESS_OBJECT_ID");

                entity.Property(e => e.ParentEntityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_ENTITY_CODE");

                entity.Property(e => e.PlShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PL_SHORT_NAME");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_NAME");

                entity.Property(e => e.ReportServerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_SERVER_NAME");

                entity.Property(e => e.ReportServerTestUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_SERVER_TEST_URL");

                entity.Property(e => e.ReviewExistingData)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVIEW_EXISTING_DATA");

                entity.Property(e => e.ReviewPrioritizer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVIEW_PRIORITIZER");

                entity.Property(e => e.ReviewPriority)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVIEW_PRIORITY");

                entity.Property(e => e.SeedDataRequestor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_REQUESTOR");

                entity.Property(e => e.SeedDataReviewer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_REVIEWER");

                entity.Property(e => e.SeedDataType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_TYPE");

                entity.Property(e => e.SeedReviewProcessFusion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_REVIEW_PROCESS_FUSION");

                entity.Property(e => e.SeedReviewProcessToday)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_REVIEW_PROCESS_TODAY");

                entity.Property(e => e.ServiceAm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_AM");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SERVICE_ID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_NAME");

                entity.Property(e => e.ServiceSdo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_SDO");

                entity.Property(e => e.ServiceSdoVo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_SDO_VO");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_TYPE");

                entity.Property(e => e.ServiceVisibility)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE_VISIBILITY");

                entity.Property(e => e.SetupComments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETUP_COMMENTS");

                entity.Property(e => e.StoreSeedData)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STORE_SEED_DATA");

                entity.Property(e => e.SubDiscriminatorValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUB_DISCRIMINATOR_VALUE");

                entity.Property(e => e.SubtypeDiscriminator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBTYPE_DISCRIMINATOR");

                entity.Property(e => e.SubtypeDiscriminatorId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUBTYPE_DISCRIMINATOR_ID");

                entity.Property(e => e.SupertypeBusinessObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPERTYPE_BUSINESS_OBJECT_ID");

                entity.Property(e => e.SupportEmbedUi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_EMBED_UI");

                entity.Property(e => e.SupportMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_MOBILE");

                entity.Property(e => e.SupportPlsqlApi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_PLSQL_API");

                entity.Property(e => e.SupportPubTableView)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_PUB_TABLE_VIEW");

                entity.Property(e => e.SupportReplication)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_REPLICATION");

                entity.Property(e => e.SupportServiceOper)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_SERVICE_OPER");

                entity.Property(e => e.Svp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SVP");

                entity.Property(e => e.SwitchableEo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SWITCHABLE_EO");

                entity.Property(e => e.SwitchableVo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SWITCHABLE_VO");

                entity.Property(e => e.TestUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEST_URL");

                entity.Property(e => e.TransformAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFORM_ALLOWED_FLAG");

                entity.Property(e => e.UpdateAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_ALLOWED_FLAG");

                entity.Property(e => e.Vp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VP");

                entity.Property(e => e.XmlFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("XML_FILE_NAME");

                entity.Property(e => e.XmlNodePath)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("XML_NODE_PATH");
            });

            modelBuilder.Entity<AskTasksVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASK_TASKS_VL", "FUSION");

                entity.Property(e => e.AdfTaskFlow)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ADF_TASK_FLOW");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.AvailableReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_RELEASE_VERSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeliveryReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_RELEASE_VERSION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.EnterpriseAppShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTERPRISE_APP_SHORT_NAME");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.EssProgramId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESS_PROGRAM_ID");

                entity.Property(e => e.ExpirationReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION_RELEASE_VERSION");

                entity.Property(e => e.FullWindowUiInvocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_WINDOW_UI_INVOCATION");

                entity.Property(e => e.HelpTopicId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HELP_TOPIC_ID");

                entity.Property(e => e.InvocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVOCATION_TYPE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ModuleShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_SHORT_NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Parameters)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETERS");

                entity.Property(e => e.PerformTaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERFORM_TASK_TYPE");

                entity.Property(e => e.ProducerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCER_ID");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TARGET");

                entity.Property(e => e.TaskDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TASK_DESC");

                entity.Property(e => e.TaskFlowId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_FLOW_ID");

                entity.Property(e => e.TaskId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_ID");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TASK_NAME");

                entity.Property(e => e.TaskShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TASK_SHORT_NAME");

                entity.Property(e => e.TaskTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TASK_TYPE_CODE");

                entity.Property(e => e.TestApplicationLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEST_APPLICATION_LOCATION");

                entity.Property(e => e.UiMockupUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UI_MOCKUP_URL");

                entity.Property(e => e.WireframeUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WIREFRAME_URL");
            });

            modelBuilder.Entity<AsmFilterOptionsFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_FILTER_OPTIONS_FILTERS", "FUSION");

                entity.Property(e => e.AutoEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_ENABLED_FLAG");

                entity.Property(e => e.AutoEnabledReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_ENABLED_RELEASE_VERSION");

                entity.Property(e => e.AvailableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_FLAG");

                entity.Property(e => e.AvailableReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_RELEASE_VERSION");

                entity.Property(e => e.ChildType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_TYPE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefaultFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeliveryReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_RELEASE_VERSION");

                entity.Property(e => e.DisplaySequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DISPLAY_SEQUENCE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.ExpirationReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION_RELEASE_VERSION");

                entity.Property(e => e.FilterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_ID");

                entity.Property(e => e.FilterOptionFilterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_OPTION_FILTER_ID");

                entity.Property(e => e.FilterOptionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_OPTION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OraSeedSet1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORA_SEED_SET1");

                entity.Property(e => e.OraSeedSet2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORA_SEED_SET2");

                entity.Property(e => e.QuickSetupTaskId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUICK_SETUP_TASK_ID");

                entity.Property(e => e.QuickSetupTaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUICK_SETUP_TASK_LIST_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");
            });

            modelBuilder.Entity<AsmFilterOptionsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_FILTER_OPTIONS_VL", "FUSION");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.AvailableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_FLAG");

                entity.Property(e => e.AvailableReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_RELEASE_VERSION");

                entity.Property(e => e.CheckedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHECKED_FLAG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefaultOptionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_OPTION_FLAG");

                entity.Property(e => e.DefaultOptionOnUpgradeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_OPTION_ON_UPGRADE_FLAG");

                entity.Property(e => e.DeliveryReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_RELEASE_VERSION");

                entity.Property(e => e.DisplaySequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DISPLAY_SEQUENCE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.ExpirationReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION_RELEASE_VERSION");

                entity.Property(e => e.FilterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_ID");

                entity.Property(e => e.FilterOptionDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_OPTION_DESC");

                entity.Property(e => e.FilterOptionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_OPTION_ID");

                entity.Property(e => e.FilterOptionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_OPTION_NAME");

                entity.Property(e => e.FilterOptionShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_OPTION_SHORT_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.NoneChoiceFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NONE_CHOICE_FLAG");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ProvisionConfigShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROVISION_CONFIG_SHORT_NAME");

                entity.Property(e => e.PublishInWhatsnewFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISH_IN_WHATSNEW_FLAG");

                entity.Property(e => e.WhatsnewReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WHATSNEW_RELEASE_VERSION");
            });

            modelBuilder.Entity<AsmFiltersVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_FILTERS_VL", "FUSION");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.AvailableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_FLAG");

                entity.Property(e => e.AvailableReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_RELEASE_VERSION");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_OBJECT_ID");

                entity.Property(e => e.CfgTemplateId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CFG_TEMPLATE_ID");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DbCacheEnableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DB_CACHE_ENABLE_FLAG");

                entity.Property(e => e.DeliveryReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_RELEASE_VERSION");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.ExpirationReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION_RELEASE_VERSION");

                entity.Property(e => e.ExtSourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXT_SOURCE_ID");

                entity.Property(e => e.ExtSourceLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXT_SOURCE_LAST_UPDATE_DATE");

                entity.Property(e => e.ExtSourceLastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXT_SOURCE_LAST_UPDATED_BY");

                entity.Property(e => e.ExtSourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXT_SOURCE_NAME");

                entity.Property(e => e.FilterDesc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_DESC");

                entity.Property(e => e.FilterFile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_FILE");

                entity.Property(e => e.FilterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_ID");

                entity.Property(e => e.FilterName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_NAME");

                entity.Property(e => e.FilterShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_SHORT_NAME");

                entity.Property(e => e.HelpTopicId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HELP_TOPIC_ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_FILE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OptInTaskShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPT_IN_TASK_SHORT_NAME");

                entity.Property(e => e.OptionTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPTION_TYPE_CODE");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.PromoCodeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROMO_CODE_FLAG");

                entity.Property(e => e.Prompt)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PROMPT");

                entity.Property(e => e.PublishInWhatsnewFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISH_IN_WHATSNEW_FLAG");

                entity.Property(e => e.PublishedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PUBLISHED_DATE");

                entity.Property(e => e.QuickSetupTaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUICK_SETUP_TASK_LIST_ID");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SERVICE_ID");

                entity.Property(e => e.TaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_LIST_ID");

                entity.Property(e => e.UsageState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USAGE_STATE");

                entity.Property(e => e.WhatsnewReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WHATSNEW_RELEASE_VERSION");
            });

            modelBuilder.Entity<AsmScope>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_SCOPES", "FUSION");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_OBJECT_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MigrationOnly)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MIGRATION_ONLY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ScopeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SCOPE_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.TaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_LIST_ID");
            });

            modelBuilder.Entity<AsmSvsFilterOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_SVS_FILTER_OPTIONS", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.FilterOptionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FILTER_OPTION_ID");

                entity.Property(e => e.FreezeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FREEZE_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ScopeValueSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SCOPE_VALUE_SET_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.SvsFilterOptionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SVS_FILTER_OPTION_ID");
            });

            modelBuilder.Entity<AsmTaskListItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_TASK_LIST_ITEMS", "FUSION");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeepCopyFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEEP_COPY_FLAG");

                entity.Property(e => e.DisplaySequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DISPLAY_SEQUENCE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.ItemTaskId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITEM_TASK_ID");

                entity.Property(e => e.ItemTaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITEM_TASK_LIST_ID");

                entity.Property(e => e.ItemTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TYPE_CODE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MandatoryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANDATORY_FLAG");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.Parameters)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETERS");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.TaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_LIST_ID");

                entity.Property(e => e.TaskListItemId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_LIST_ITEM_ID");

                entity.Property(e => e.TaskListItemShortName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TASK_LIST_ITEM_SHORT_NAME");
            });

            modelBuilder.Entity<AsmTaskListsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASM_TASK_LISTS_VL", "FUSION");

                entity.Property(e => e.ActivityTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_TYPE_CODE");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.AvailableReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABLE_RELEASE_VERSION");

                entity.Property(e => e.CopyEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_ENABLED_FLAG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeepCopyFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEEP_COPY_FLAG");

                entity.Property(e => e.DeliveryReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERY_RELEASE_VERSION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.ExpirationReleaseVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPIRATION_RELEASE_VERSION");

                entity.Property(e => e.FusionRelease)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUSION_RELEASE");

                entity.Property(e => e.HelpTopicId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HELP_TOPIC_ID");

                entity.Property(e => e.HierarchyNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIERARCHY_NUMBER");

                entity.Property(e => e.InContextFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IN_CONTEXT_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrigTaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORIG_TASK_LIST_ID");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SERVICE_ID");

                entity.Property(e => e.TaskListDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("TASK_LIST_DESC");

                entity.Property(e => e.TaskListId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TASK_LIST_ID");

                entity.Property(e => e.TaskListName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TASK_LIST_NAME");

                entity.Property(e => e.TaskListShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TASK_LIST_SHORT_NAME");
            });

            modelBuilder.Entity<CstCostOrgsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CST_COST_ORGS_V", "FUSION");

                entity.Property(e => e.CostOrgCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COST_ORG_CODE");

                entity.Property(e => e.CostOrgId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_ORG_ID");

                entity.Property(e => e.CostOrgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COST_ORG_NAME");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FaBookControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FA_BOOK_CONTROLS", "FUSION");

                entity.Property(e => e.AccountingFlexStructure)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACCOUNTING_FLEX_STRUCTURE");

                entity.Property(e => e.AdvancedOptionsEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADVANCED_OPTIONS_ENABLED_FLAG");

                entity.Property(e => e.AllowBackdatedTransfersFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_BACKDATED_TRANSFERS_FLAG");

                entity.Property(e => e.AllowBonusDeprnFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_BONUS_DEPRN_FLAG");

                entity.Property(e => e.AllowCipAssetsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_CIP_ASSETS_FLAG");

                entity.Property(e => e.AllowCipDepGroupFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_CIP_DEP_GROUP_FLAG");

                entity.Property(e => e.AllowCipMemberFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_CIP_MEMBER_FLAG");

                entity.Property(e => e.AllowCostBasedRevalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_COST_BASED_REVAL_FLAG");

                entity.Property(e => e.AllowCostCeiling)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_COST_CEILING");

                entity.Property(e => e.AllowCostSignChangeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_COST_SIGN_CHANGE_FLAG");

                entity.Property(e => e.AllowDeprnAdjustments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DEPRN_ADJUSTMENTS");

                entity.Property(e => e.AllowDeprnExpCeiling)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DEPRN_EXP_CEILING");

                entity.Property(e => e.AllowDeprnOverrideFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DEPRN_OVERRIDE_FLAG");

                entity.Property(e => e.AllowDirectTaxAdditionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DIRECT_TAX_ADDITION_FLAG");

                entity.Property(e => e.AllowFundAccountingFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_FUND_ACCOUNTING_FLAG");

                entity.Property(e => e.AllowGroupDeprnFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_GROUP_DEPRN_FLAG");

                entity.Property(e => e.AllowIntercoGroupFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_INTERCO_GROUP_FLAG");

                entity.Property(e => e.AllowLeasesFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_LEASES_FLAG");

                entity.Property(e => e.AllowMassChanges)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_MASS_CHANGES");

                entity.Property(e => e.AllowMassCopy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_MASS_COPY");

                entity.Property(e => e.AllowMemberTrackingFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_MEMBER_TRACKING_FLAG");

                entity.Property(e => e.AllowNbvBasedRevalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_NBV_BASED_REVAL_FLAG");

                entity.Property(e => e.AllowPhysicalInventoryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_PHYSICAL_INVENTORY_FLAG");

                entity.Property(e => e.AllowPurgeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_PURGE_FLAG");

                entity.Property(e => e.AllowRevalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_REVAL_FLAG");

                entity.Property(e => e.AllowTaxDistributionsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_TAX_DISTRIBUTIONS_FLAG");

                entity.Property(e => e.AllowTransConventionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_TRANS_CONVENTION_FLAG");

                entity.Property(e => e.AllowUkGovernmentRevalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_UK_GOVERNMENT_REVAL_FLAG");

                entity.Property(e => e.AllowUnallocatedLinesFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_UNALLOCATED_LINES_FLAG");

                entity.Property(e => e.AmortizeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMORTIZE_FLAG");

                entity.Property(e => e.AmortizeRevalReserveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AMORTIZE_REVAL_RESERVE_FLAG");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY_CODE");

                entity.Property(e => e.BookClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOOK_CLASS");

                entity.Property(e => e.BookControlId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BOOK_CONTROL_ID");

                entity.Property(e => e.BookTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOOK_TYPE_CODE");

                entity.Property(e => e.BookTypeMigrationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOOK_TYPE_MIGRATION_FLAG");

                entity.Property(e => e.BookTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOOK_TYPE_NAME");

                entity.Property(e => e.CapThresholdAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAP_THRESHOLD_AMOUNT");

                entity.Property(e => e.CapThresholdType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAP_THRESHOLD_TYPE");

                entity.Property(e => e.CapitalGainThreshold)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAPITAL_GAIN_THRESHOLD");

                entity.Property(e => e.CopyAdditionsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_ADDITIONS_FLAG");

                entity.Property(e => e.CopyAdjustmentsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_ADJUSTMENTS_FLAG");

                entity.Property(e => e.CopyAllCostAdjustmentsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_ALL_COST_ADJUSTMENTS_FLAG");

                entity.Property(e => e.CopyAmortAdajExpFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_AMORT_ADAJ_EXP_FLAG");

                entity.Property(e => e.CopyGroupAdditionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_GROUP_ADDITION_FLAG");

                entity.Property(e => e.CopyGroupAssignmentFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_GROUP_ASSIGNMENT_FLAG");

                entity.Property(e => e.CopyGroupChangeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_GROUP_CHANGE_FLAG");

                entity.Property(e => e.CopyLeaseAssetsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_LEASE_ASSETS_FLAG");

                entity.Property(e => e.CopyLeaseSchedulesFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_LEASE_SCHEDULES_FLAG");

                entity.Property(e => e.CopyRetirementsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_RETIREMENTS_FLAG");

                entity.Property(e => e.CopySalvageValueFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_SALVAGE_VALUE_FLAG");

                entity.Property(e => e.CopyTransfersFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_TRANSFERS_FLAG");

                entity.Property(e => e.CostOfRemovalClearingAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_OF_REMOVAL_CLEARING_ACCT");

                entity.Property(e => e.CostOfRemovalGainAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_OF_REMOVAL_GAIN_ACCT");

                entity.Property(e => e.CostOfRemovalLossAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_OF_REMOVAL_LOSS_ACCT");

                entity.Property(e => e.CreateAccountingRequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATE_ACCOUNTING_REQUEST_ID");

                entity.Property(e => e.CreateAccountingRunDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_ACCOUNTING_RUN_DATE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CurrentFiscalYear)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CURRENT_FISCAL_YEAR");

                entity.Property(e => e.DefaultDpisToInvDateFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_DPIS_TO_INV_DATE_FLAG");

                entity.Property(e => e.DefaultLifeExtensionCeiling)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_LIFE_EXTENSION_CEILING");

                entity.Property(e => e.DefaultLifeExtensionFactor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_LIFE_EXTENSION_FACTOR");

                entity.Property(e => e.DefaultMaxFullyRsvdRevals)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_MAX_FULLY_RSVD_REVALS");

                entity.Property(e => e.DefaultPeriodEndRevalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_PERIOD_END_REVAL_FLAG");

                entity.Property(e => e.DefaultRevalFullyRsvdFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_REVAL_FULLY_RSVD_FLAG");

                entity.Property(e => e.DeferredDeprnExpenseAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFERRED_DEPRN_EXPENSE_ACCT");

                entity.Property(e => e.DeferredDeprnReserveAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFERRED_DEPRN_RESERVE_ACCT");

                entity.Property(e => e.DeprnAdjustmentAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPRN_ADJUSTMENT_ACCT");

                entity.Property(e => e.DeprnCalendar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPRN_CALENDAR");

                entity.Property(e => e.DeprnRequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPRN_REQUEST_ID");

                entity.Property(e => e.DeprnStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPRN_STATUS");

                entity.Property(e => e.DistributionSourceBook)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRIBUTION_SOURCE_BOOK");

                entity.Property(e => e.FiscalYearName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL_YEAR_NAME");

                entity.Property(e => e.FlexbuilderDefaultsCcid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FLEXBUILDER_DEFAULTS_CCID");

                entity.Property(e => e.FullyReservedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULLY_RESERVED_FLAG");

                entity.Property(e => e.GlPostingAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GL_POSTING_ALLOWED_FLAG");

                entity.Property(e => e.GlobalAttribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE1");

                entity.Property(e => e.GlobalAttribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE11");

                entity.Property(e => e.GlobalAttribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE12");

                entity.Property(e => e.GlobalAttribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE13");

                entity.Property(e => e.GlobalAttribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE14");

                entity.Property(e => e.GlobalAttribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE15");

                entity.Property(e => e.GlobalAttribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE16");

                entity.Property(e => e.GlobalAttribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE17");

                entity.Property(e => e.GlobalAttribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE18");

                entity.Property(e => e.GlobalAttribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE19");

                entity.Property(e => e.GlobalAttribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE2");

                entity.Property(e => e.GlobalAttribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE20");

                entity.Property(e => e.GlobalAttribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE3");

                entity.Property(e => e.GlobalAttribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE4");

                entity.Property(e => e.GlobalAttribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE5");

                entity.Property(e => e.GlobalAttribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE6");

                entity.Property(e => e.GlobalAttribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE7");

                entity.Property(e => e.GlobalAttribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE8");

                entity.Property(e => e.GlobalAttribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE9");

                entity.Property(e => e.GlobalAttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_CATEGORY");

                entity.Property(e => e.GlobalAttributeDate1)
                    .HasColumnType("DATE")
                    .HasColumnName("GLOBAL_ATTRIBUTE_DATE1");

                entity.Property(e => e.GlobalAttributeDate2)
                    .HasColumnType("DATE")
                    .HasColumnName("GLOBAL_ATTRIBUTE_DATE2");

                entity.Property(e => e.GlobalAttributeDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("GLOBAL_ATTRIBUTE_DATE3");

                entity.Property(e => e.GlobalAttributeDate4)
                    .HasColumnType("DATE")
                    .HasColumnName("GLOBAL_ATTRIBUTE_DATE4");

                entity.Property(e => e.GlobalAttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_NUMBER1");

                entity.Property(e => e.GlobalAttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_NUMBER2");

                entity.Property(e => e.GlobalAttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_NUMBER3");

                entity.Property(e => e.GlobalAttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_NUMBER4");

                entity.Property(e => e.GlobalAttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_NUMBER5");

                entity.Property(e => e.ImmediateCopyFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMMEDIATE_COPY_FLAG");

                entity.Property(e => e.IndexRevalPeriodNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INDEX_REVAL_PERIOD_NUM");

                entity.Property(e => e.InitialDate)
                    .HasColumnType("DATE")
                    .HasColumnName("INITIAL_DATE");

                entity.Property(e => e.InitialPeriodCounter)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INITIAL_PERIOD_COUNTER");

                entity.Property(e => e.ItcAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITC_ALLOWED_FLAG");

                entity.Property(e => e.LastCreateMassAdditionsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_CREATE_MASS_ADDITIONS_ID");

                entity.Property(e => e.LastDepreciationRunDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_DEPRECIATION_RUN_DATE");

                entity.Property(e => e.LastDeprnRunDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_DEPRN_RUN_DATE");

                entity.Property(e => e.LastLeaseExpenseRunDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_LEASE_EXPENSE_RUN_DATE");

                entity.Property(e => e.LastMassCopyPeriodCounter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_MASS_COPY_PERIOD_COUNTER");

                entity.Property(e => e.LastPeriodCounter)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_PERIOD_COUNTER");

                entity.Property(e => e.LastPostMassAdditionsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_POST_MASS_ADDITIONS_ID");

                entity.Property(e => e.LastPurgePeriodCounter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_PURGE_PERIOD_COUNTER");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LeaseCurrRateGainLossFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEASE_CURR_RATE_GAIN_LOSS_FLAG");

                entity.Property(e => e.LeaseExpenseRunFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEASE_EXPENSE_RUN_FLAG");

                entity.Property(e => e.LeaseMigrationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEASE_MIGRATION_FLAG");

                entity.Property(e => e.MassCopySourceBook)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASS_COPY_SOURCE_BOOK");

                entity.Property(e => e.MassRequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MASS_REQUEST_ID");

                entity.Property(e => e.McSourceFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MC_SOURCE_FLAG");

                entity.Property(e => e.NbvAmountThreshold)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NBV_AMOUNT_THRESHOLD");

                entity.Property(e => e.NbvFractionThreshold)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NBV_FRACTION_THRESHOLD");

                entity.Property(e => e.NbvRetiredGainAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NBV_RETIRED_GAIN_ACCT");

                entity.Property(e => e.NbvRetiredLossAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NBV_RETIRED_LOSS_ACCT");

                entity.Property(e => e.NonSaleGainAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NON_SALE_GAIN_ACCT");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PreventPriorPeriodTxnsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREVENT_PRIOR_PERIOD_TXNS_FLAG");

                entity.Property(e => e.ProceedsOfSaleClearingAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROCEEDS_OF_SALE_CLEARING_ACCT");

                entity.Property(e => e.ProceedsOfSaleGainAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROCEEDS_OF_SALE_GAIN_ACCT");

                entity.Property(e => e.ProceedsOfSaleLossAcct)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROCEEDS_OF_SALE_LOSS_ACCT");

                entity.Property(e => e.ProrateCalendar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRORATE_CALENDAR");

                entity.Property(e => e.RequireLocationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_LOCATION_FLAG");

                entity.Property(e => e.RetireRevalReserveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RETIRE_REVAL_RESERVE_FLAG");

                entity.Property(e => e.RevalDeprnReserveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVAL_DEPRN_RESERVE_FLAG");

                entity.Property(e => e.RevalRsvRetiredGainAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVAL_RSV_RETIRED_GAIN_ACCT");

                entity.Property(e => e.RevalRsvRetiredLossAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVAL_RSV_RETIRED_LOSS_ACCT");

                entity.Property(e => e.RevalYtdDeprnFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVAL_YTD_DEPRN_FLAG");

                entity.Property(e => e.RoundAnnualDepreciation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROUND_ANNUAL_DEPRECIATION");

                entity.Property(e => e.SetOfBooksId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_OF_BOOKS_ID");

                entity.Property(e => e.SorpEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SORP_ENABLED_FLAG");

                entity.Property(e => e.SuppressInvAutoMergeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPRESS_INV_AUTO_MERGE_FLAG");

                entity.Property(e => e.TrackSourceLinesInTaxFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACK_SOURCE_LINES_IN_TAX_FLAG");

                entity.Property(e => e.UseFirstDateAsTrxDate)
                    .HasColumnType("DATE")
                    .HasColumnName("USE_FIRST_DATE_AS_TRX_DATE");

                entity.Property(e => e.UseNbvThresholdFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USE_NBV_THRESHOLD_FLAG");

                entity.Property(e => e.UsePercentSalvageValueFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USE_PERCENT_SALVAGE_VALUE_FLAG");
            });

            modelBuilder.Entity<FndApplicationVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_APPLICATION_VL", "FUSION");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("APPLICATION_ID");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION_NAME");

                entity.Property(e => e.ApplicationShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION_SHORT_NAME");

                entity.Property(e => e.Basepath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BASEPATH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_CODE");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");
            });

            modelBuilder.Entity<FndCompiledMenuFunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_COMPILED_MENU_FUNCTIONS", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLAG");

                entity.Property(e => e.FunctionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FUNCTION_ID");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.SandboxId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SANDBOX_ID");
            });

            modelBuilder.Entity<FndFormFunctionsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_FORM_FUNCTIONS_VL", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FunctionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FUNCTION_ID");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_NAME");

                entity.Property(e => e.FunctionSecurityOnly)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_SECURITY_ONLY");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.UserFunctionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_FUNCTION_NAME");
            });

            modelBuilder.Entity<FndGrant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_GRANTS", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CompileFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPILE_FLAG");

                entity.Property(e => e.ContextName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_NAME");

                entity.Property(e => e.ContextValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTEXT_VALUE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.GrantGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRANT_GUID");

                entity.Property(e => e.GrantType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRANT_TYPE");

                entity.Property(e => e.GranteeKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRANTEE_KEY");

                entity.Property(e => e.GranteeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRANTEE_TYPE");

                entity.Property(e => e.InstancePk1Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_PK1_VALUE");

                entity.Property(e => e.InstancePk2Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_PK2_VALUE");

                entity.Property(e => e.InstancePk3Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_PK3_VALUE");

                entity.Property(e => e.InstancePk4Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_PK4_VALUE");

                entity.Property(e => e.InstancePk5Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_PK5_VALUE");

                entity.Property(e => e.InstanceSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INSTANCE_SET_ID");

                entity.Property(e => e.InstanceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_TYPE");

                entity.Property(e => e.IsEnterpriseRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IS_ENTERPRISE_ROLE");

                entity.Property(e => e.J2eeAppName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("J2EE_APP_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Parameter1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER1");

                entity.Property(e => e.Parameter10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER10");

                entity.Property(e => e.Parameter2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER2");

                entity.Property(e => e.Parameter3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER3");

                entity.Property(e => e.Parameter4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER4");

                entity.Property(e => e.Parameter5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER5");

                entity.Property(e => e.Parameter6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER6");

                entity.Property(e => e.Parameter7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER7");

                entity.Property(e => e.Parameter8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER8");

                entity.Property(e => e.Parameter9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMETER9");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");

                entity.Property(e => e.ProgramTag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_TAG");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");

                entity.Property(e => e.RoleNameSpace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME_SPACE");

                entity.Property(e => e.SandboxId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SANDBOX_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");
            });

            modelBuilder.Entity<FndLookupValuesVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_LOOKUP_VALUES_VL", "FUSION");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATED_BY_USER_ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EndDateActive)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE_ACTIVE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATED_BY_USER_ID");

                entity.Property(e => e.LookupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOOKUP_CODE");

                entity.Property(e => e.LookupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOOKUP_TYPE");

                entity.Property(e => e.Meaning)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MEANING");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.StartDateActive)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE_ACTIVE");

                entity.Property(e => e.ViewApplicationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("VIEW_APPLICATION_ID");
            });

            modelBuilder.Entity<FndMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_MENUS", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MENU_NAME");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.SandboxId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SANDBOX_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");
            });

            modelBuilder.Entity<FndMenuEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_MENU_ENTRIES", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.FunctionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FUNCTION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MenuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MENU_ID");

                entity.Property(e => e.SandboxId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SANDBOX_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.SubMenuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUB_MENU_ID");
            });

            modelBuilder.Entity<FndObjectInstanceSetsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_OBJECT_INSTANCE_SETS_VL", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_NAME");

                entity.Property(e => e.DisplayShortName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_SHORT_NAME");

                entity.Property(e => e.Filter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILTER");

                entity.Property(e => e.InstanceSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INSTANCE_SET_ID");

                entity.Property(e => e.InstanceSetName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTANCE_SET_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Predicate)
                    .HasMaxLength(1550)
                    .IsUnicode(false)
                    .HasColumnName("PREDICATE");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_NAME");

                entity.Property(e => e.ProgramTag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAM_TAG");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");
            });

            modelBuilder.Entity<FndObjectsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_OBJECTS_VL", "FUSION");

                entity.Property(e => e.ChangeSinceLastRefresh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_SINCE_LAST_REFRESH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DatabaseObjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATABASE_OBJECT_NAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(850)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_NAME");

                entity.Property(e => e.FilterColumnList)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_COLUMN_LIST");

                entity.Property(e => e.FunctionSecurityEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTION_SECURITY_ENABLED");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJ_NAME");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.ObjectStripeCondition)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_STRIPE_CONDITION");

                entity.Property(e => e.ObjectTag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TAG");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TYPE");

                entity.Property(e => e.Pk1ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK1_COLUMN_NAME");

                entity.Property(e => e.Pk1ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK1_COLUMN_TYPE");

                entity.Property(e => e.Pk2ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK2_COLUMN_NAME");

                entity.Property(e => e.Pk2ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK2_COLUMN_TYPE");

                entity.Property(e => e.Pk3ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK3_COLUMN_NAME");

                entity.Property(e => e.Pk3ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK3_COLUMN_TYPE");

                entity.Property(e => e.Pk4ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK4_COLUMN_NAME");

                entity.Property(e => e.Pk4ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK4_COLUMN_TYPE");

                entity.Property(e => e.Pk5ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK5_COLUMN_NAME");

                entity.Property(e => e.Pk5ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PK5_COLUMN_TYPE");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");
            });

            modelBuilder.Entity<FndSetidSetsVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FND_SETID_SETS_VL", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.SetCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SET_CODE");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.SetName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SET_NAME");
            });

            modelBuilder.Entity<FunAllBusinessUnitsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FUN_ALL_BUSINESS_UNITS_V", "FUSION");

                entity.Property(e => e.BuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BU_ID");

                entity.Property(e => e.BuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU_NAME");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.DefaultCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_CURRENCY_CODE");

                entity.Property(e => e.DefaultSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_SET_ID");

                entity.Property(e => e.EnabledForHrFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FOR_HR_FLAG");

                entity.Property(e => e.FinBusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FIN_BUSINESS_UNIT_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.PrimaryLedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_LEDGER_ID");

                entity.Property(e => e.ProfitCenterFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROFIT_CENTER_FLAG");

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_CODE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FunFinBusinessUnitsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FUN_FIN_BUSINESS_UNITS_V", "FUSION");

                entity.Property(e => e.BuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BU_ID");

                entity.Property(e => e.BuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU_NAME");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.DefaultCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_CURRENCY_CODE");

                entity.Property(e => e.DefaultSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_SET_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.PrimaryLedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_LEDGER_ID");

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_CODE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<FunIntercoOrganization>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FUN_INTERCO_ORGANIZATIONS", "FUSION");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute16)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE16");

                entity.Property(e => e.Attribute17)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE17");

                entity.Property(e => e.Attribute18)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE18");

                entity.Property(e => e.Attribute19)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE19");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute20)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE20");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(255)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.ContactPersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONTACT_PERSON_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(255)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.IntercoOrgId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INTERCO_ORG_ID");

                entity.Property(e => e.IntercoOrgName)
                    .HasMaxLength(255)
                    .HasColumnName("INTERCO_ORG_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(255)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(255)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PayBuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PAY_BU_ID");

                entity.Property(e => e.RecBuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REC_BU_ID");

                entity.Property(e => e.RemoteInstanceFlag)
                    .HasMaxLength(255)
                    .HasColumnName("REMOTE_INSTANCE_FLAG");

                entity.Property(e => e.RemoteInstanceIdentifier)
                    .HasMaxLength(255)
                    .HasColumnName("REMOTE_INSTANCE_IDENTIFIER");
            });

            modelBuilder.Entity<FunUserRoleDataAsgnmnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FUN_USER_ROLE_DATA_ASGNMNTS", "FUSION");

                entity.Property(e => e.AccessSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACCESS_SET_ID");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.BookId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BOOK_ID");

                entity.Property(e => e.CollaborationDocId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COLLABORATION_DOC_ID");

                entity.Property(e => e.ControlBudgetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONTROL_BUDGET_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CstOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CST_ORGANIZATION_ID");

                entity.Property(e => e.DatasecContextTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_TYPE_CODE");

                entity.Property(e => e.DatasecContextValue1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_VALUE1");

                entity.Property(e => e.DatasecContextValue2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_VALUE2");

                entity.Property(e => e.DatasecContextValue3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_VALUE3");

                entity.Property(e => e.DatasecContextValue4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_VALUE4");

                entity.Property(e => e.DatasecContextValue5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATASEC_CONTEXT_VALUE5");

                entity.Property(e => e.EndDateActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("END_DATE_ACTIVE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.IntercoOrgId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INTERCO_ORG_ID");

                entity.Property(e => e.InvOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INV_ORGANIZATION_ID");

                entity.Property(e => e.ItmOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITM_ORGANIZATION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEDGER_ID");

                entity.Property(e => e.MfgOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MFG_ORGANIZATION_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrgId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORG_ID");

                entity.Property(e => e.PrjOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRJ_ORGANIZATION_ID");

                entity.Property(e => e.RecordTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_TYPE_CODE");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.StartDateActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("START_DATE_ACTIVE");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GUID");

                entity.Property(e => e.UserRoleDataAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ROLE_DATA_ASSIGNMENT_ID");
            });

            modelBuilder.Entity<GlAccessSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL_ACCESS_SETS", "FUSION");

                entity.Property(e => e.AccessSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACCESS_SET_ID");

                entity.Property(e => e.AccountedPeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTED_PERIOD_TYPE");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AutomaticallyCreatedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTOMATICALLY_CREATED_FLAG");

                entity.Property(e => e.ChartOfAccountsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CHART_OF_ACCOUNTS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefaultLedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_LEDGER_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PeriodSetName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_SET_NAME");

                entity.Property(e => e.SecuredSegValueSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SECURED_SEG_VALUE_SET_ID");

                entity.Property(e => e.SecuritySegmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_SEGMENT_CODE");
            });

            modelBuilder.Entity<GlCodeCombination>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL_CODE_COMBINATIONS", "FUSION");

                entity.Property(e => e.AlternateCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ALTERNATE_CODE_COMBINATION_ID");

                entity.Property(e => e.CodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CODE_COMBINATION_ID");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATED_BY_USER_ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EndDateActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("END_DATE_ACTIVE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATED_BY_USER_ID");

                entity.Property(e => e.PDateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("_P_DATE_FROM");

                entity.Property(e => e.PDateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("_P_DATE_TO");

                entity.Property(e => e.RevaluationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REVALUATION_ID");

                entity.Property(e => e.StartDateActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("START_DATE_ACTIVE");
            });

            modelBuilder.Entity<GlLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL_LEDGERS", "FUSION");

                entity.Property(e => e.AccountedPeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTED_PERIOD_TYPE");

                entity.Property(e => e.AlcLedgerTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALC_LEDGER_TYPE_CODE");

                entity.Property(e => e.AllowIntercompanyPostFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_INTERCOMPANY_POST_FLAG");

                entity.Property(e => e.ApDocSequencingOptionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AP_DOC_SEQUENCING_OPTION_FLAG");

                entity.Property(e => e.ArDocSequencingOptionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AR_DOC_SEQUENCING_OPTION_FLAG");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AutomateSecJrnlRevFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTOMATE_SEC_JRNL_REV_FLAG");

                entity.Property(e => e.AutomaticallyCreatedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTOMATICALLY_CREATED_FLAG");

                entity.Property(e => e.AutorevAfterOpenPrdFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTOREV_AFTER_OPEN_PRD_FLAG");

                entity.Property(e => e.BalSegColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAL_SEG_COLUMN_NAME");

                entity.Property(e => e.BalSegValueOptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAL_SEG_VALUE_OPTION_CODE");

                entity.Property(e => e.BalSegValueSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BAL_SEG_VALUE_SET_ID");

                entity.Property(e => e.BudgetPeriodAvgRateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_PERIOD_AVG_RATE_TYPE");

                entity.Property(e => e.BudgetPeriodEndRateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_PERIOD_END_RATE_TYPE");

                entity.Property(e => e.ChartOfAccountsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CHART_OF_ACCOUNTS_ID");

                entity.Property(e => e.CompleteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETE_FLAG");

                entity.Property(e => e.CompletionStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETION_STATUS_CODE");

                entity.Property(e => e.ConfigurationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONFIGURATION_ID");

                entity.Property(e => e.ConsolidationLedgerFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONSOLIDATION_LEDGER_FLAG");

                entity.Property(e => e.CreateJeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_JE_FLAG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CriteriaSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CRITERIA_SET_ID");

                entity.Property(e => e.CrossLgrClrAccCcid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CROSS_LGR_CLR_ACC_CCID");

                entity.Property(e => e.CumTransCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUM_TRANS_CODE_COMBINATION_ID");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY_CODE");

                entity.Property(e => e.DailyTranslationRateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAILY_TRANSLATION_RATE_TYPE");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DocSequencingOptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOC_SEQUENCING_OPTION_CODE");

                entity.Property(e => e.EnableAutomaticTaxFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_AUTOMATIC_TAX_FLAG");

                entity.Property(e => e.EnableAverageBalancesFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_AVERAGE_BALANCES_FLAG");

                entity.Property(e => e.EnableBudgetaryControlFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_BUDGETARY_CONTROL_FLAG");

                entity.Property(e => e.EnableJeApprovalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_JE_APPROVAL_FLAG");

                entity.Property(e => e.EnableReconciliationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_RECONCILIATION_FLAG");

                entity.Property(e => e.EnableRevalSsTrackFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_REVAL_SS_TRACK_FLAG");

                entity.Property(e => e.EnableSecondaryTrackFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_SECONDARY_TRACK_FLAG");

                entity.Property(e => e.EnfSeqDateCorrelationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENF_SEQ_DATE_CORRELATION_CODE");

                entity.Property(e => e.FirstLedgerPeriodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_LEDGER_PERIOD_NAME");

                entity.Property(e => e.FutureEnterablePeriodsLimit)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FUTURE_ENTERABLE_PERIODS_LIMIT");

                entity.Property(e => e.ImplicitAccessSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IMPLICIT_ACCESS_SET_ID");

                entity.Property(e => e.ImplicitLedgerSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IMPLICIT_LEDGER_SET_ID");

                entity.Property(e => e.IntercoGainLossCcid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INTERCO_GAIN_LOSS_CCID");

                entity.Property(e => e.JrnlsGroupByDateFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JRNLS_GROUP_BY_DATE_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LatestEncumbranceYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LATEST_ENCUMBRANCE_YEAR");

                entity.Property(e => e.LatestOpenedPeriodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LATEST_OPENED_PERIOD_NAME");

                entity.Property(e => e.LeLedgerTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LE_LEDGER_TYPE_CODE");

                entity.Property(e => e.LedgerAttributes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEDGER_ATTRIBUTES");

                entity.Property(e => e.LedgerCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEDGER_CATEGORY_CODE");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEDGER_ID");

                entity.Property(e => e.MgtSegColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MGT_SEG_COLUMN_NAME");

                entity.Property(e => e.MgtSegValueOptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MGT_SEG_VALUE_OPTION_CODE");

                entity.Property(e => e.MgtSegValueSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MGT_SEG_VALUE_SET_ID");

                entity.Property(e => e.MinimumThresholdAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MINIMUM_THRESHOLD_AMOUNT");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.NetClosingBalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NET_CLOSING_BAL_FLAG");

                entity.Property(e => e.NetIncomeCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NET_INCOME_CODE_COMBINATION_ID");

                entity.Property(e => e.NumberOfProcessors)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUMBER_OF_PROCESSORS");

                entity.Property(e => e.ObjectTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TYPE_CODE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PeriodAverageRateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_AVERAGE_RATE_TYPE");

                entity.Property(e => e.PeriodEndRateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_END_RATE_TYPE");

                entity.Property(e => e.PeriodSetName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_SET_NAME");

                entity.Property(e => e.PopUpStatAccountFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POP_UP_STAT_ACCOUNT_FLAG");

                entity.Property(e => e.PriorPrdNotificationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIOR_PRD_NOTIFICATION_FLAG");

                entity.Property(e => e.ProcessingUnitSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROCESSING_UNIT_SIZE");

                entity.Property(e => e.ReleaseUpgradeFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELEASE_UPGRADE_FROM");

                entity.Property(e => e.RequireBudgetJournalsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUIRE_BUDGET_JOURNALS_FLAG");

                entity.Property(e => e.ResEncumbCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RES_ENCUMB_CODE_COMBINATION_ID");

                entity.Property(e => e.RetEarnCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RET_EARN_CODE_COMBINATION_ID");

                entity.Property(e => e.RevalFromPriLgrCurr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVAL_FROM_PRI_LGR_CURR");

                entity.Property(e => e.RoundingCodeCombinationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROUNDING_CODE_COMBINATION_ID");

                entity.Property(e => e.SequencingModeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEQUENCING_MODE_CODE");

                entity.Property(e => e.ShortName)
                    .HasColumnType("FLOAT")
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.SlaAccountingMethodCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_ACCOUNTING_METHOD_CODE");

                entity.Property(e => e.SlaAccountingMethodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_ACCOUNTING_METHOD_TYPE");

                entity.Property(e => e.SlaBalByLedgerCurrFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_BAL_BY_LEDGER_CURR_FLAG");

                entity.Property(e => e.SlaDescriptionLanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_DESCRIPTION_LANGUAGE");

                entity.Property(e => e.SlaEnteredCurBalSusCcid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SLA_ENTERED_CUR_BAL_SUS_CCID");

                entity.Property(e => e.SlaLedgerCashBasisFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_LEDGER_CASH_BASIS_FLAG");

                entity.Property(e => e.SlaLedgerCurBalSusCcid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SLA_LEDGER_CUR_BAL_SUS_CCID");

                entity.Property(e => e.SlaSequencingFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_SEQUENCING_FLAG");

                entity.Property(e => e.StrictPeriodCloseFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STRICT_PERIOD_CLOSE_FLAG");

                entity.Property(e => e.SuspenseAllowedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUSPENSE_ALLOWED_FLAG");

                entity.Property(e => e.ThresholdAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("THRESHOLD_AMOUNT");

                entity.Property(e => e.TrackRoundingImbalanceFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACK_ROUNDING_IMBALANCE_FLAG");

                entity.Property(e => e.TransactionCalendarId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRANSACTION_CALENDAR_ID");

                entity.Property(e => e.TranslateEodFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSLATE_EOD_FLAG");

                entity.Property(e => e.TranslateQatdFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSLATE_QATD_FLAG");

                entity.Property(e => e.TranslateYatdFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSLATE_YATD_FLAG");

                entity.Property(e => e.UssglOptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USSGL_OPTION_CODE");

                entity.Property(e => e.ValidateJournalRefDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VALIDATE_JOURNAL_REF_DATE");
            });

            modelBuilder.Entity<GlLedgerLeV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL_LEDGER_LE_V", "FUSION");

                entity.Property(e => e.AccountedPeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTED_PERIOD_TYPE");

                entity.Property(e => e.AcctgEnvironmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCTG_ENVIRONMENT_CODE");

                entity.Property(e => e.BalSegColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAL_SEG_COLUMN_NAME");

                entity.Property(e => e.BalSegValueOptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAL_SEG_VALUE_OPTION_CODE");

                entity.Property(e => e.BalSegValueSetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BAL_SEG_VALUE_SET_ID");

                entity.Property(e => e.ChartOfAccountsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CHART_OF_ACCOUNTS_ID");

                entity.Property(e => e.ConfigurationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONFIGURATION_ID");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY_CODE");

                entity.Property(e => e.LedgerCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEDGER_CATEGORY_CODE");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEDGER_ID");

                entity.Property(e => e.LedgerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEDGER_NAME");

                entity.Property(e => e.LedgerShortName)
                    .HasColumnType("FLOAT")
                    .HasColumnName("LEDGER_SHORT_NAME");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL_ENTITY_NAME");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_DESCRIPTION");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.PeriodSetName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_SET_NAME");

                entity.Property(e => e.PrimaryLedgerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_LEDGER_ID");

                entity.Property(e => e.RelationshipEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP_ENABLED_FLAG");

                entity.Property(e => e.SlaAccountingMethodCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_ACCOUNTING_METHOD_CODE");

                entity.Property(e => e.SlaAccountingMethodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLA_ACCOUNTING_METHOD_TYPE");
            });

            modelBuilder.Entity<HrAllOrganizationUnitsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ALL_ORGANIZATION_UNITS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CostAllocationKeyflexId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_ALLOCATION_KEYFLEX_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ESTABLISHMENT_ID");

                entity.Property(e => e.InternalAddressLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_ADDRESS_LINE");

                entity.Property(e => e.InternalExternalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_EXTERNAL_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_CODE");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<HrAllPositionsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ALL_POSITIONS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.AssignmentCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_CATEGORY");

                entity.Property(e => e.BargainingUnitCd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BARGAINING_UNIT_CD");

                entity.Property(e => e.BudgetAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_AMOUNT");

                entity.Property(e => e.BudgetAmountCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_AMOUNT_CURRENCY");

                entity.Property(e => e.BudgetedPositionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGETED_POSITION_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_UNIT_ID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.CollectiveAgreementId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COLLECTIVE_AGREEMENT_ID");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COST_CENTER");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DelegatePositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELEGATE_POSITION_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EntryGradeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTRY_GRADE_ID");

                entity.Property(e => e.EntryStepId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTRY_STEP_ID");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Fte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTE");

                entity.Property(e => e.FullPartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_PART_TIME");

                entity.Property(e => e.FundedByExistingPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNDED_BY_EXISTING_POSITION");

                entity.Property(e => e.GradeLadderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_LADDER_ID");

                entity.Property(e => e.HiringStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIRING_STATUS");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.MaxPersons)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAX_PERSONS");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.OverlapAllowed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OVERLAP_ALLOWED");

                entity.Property(e => e.PermanentTemporaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERMANENT_TEMPORARY_FLAG");

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_CODE");

                entity.Property(e => e.PositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_ID");

                entity.Property(e => e.PositionSynchronizationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_SYNCHRONIZATION_FLAG");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_TYPE");

                entity.Property(e => e.ProbationPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_PERIOD");

                entity.Property(e => e.ProbationPeriodUnitCd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_PERIOD_UNIT_CD");

                entity.Property(e => e.RequisitionTemplateId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUISITION_TEMPLATE_ID");

                entity.Property(e => e.SeasonalEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SEASONAL_END_DATE");

                entity.Property(e => e.SeasonalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEASONAL_FLAG");

                entity.Property(e => e.SeasonalStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SEASONAL_START_DATE");

                entity.Property(e => e.SecurityClearance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_CLEARANCE");

                entity.Property(e => e.StandardWorkingFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STANDARD_WORKING_FREQUENCY");

                entity.Property(e => e.StandardWorkingHours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STANDARD_WORKING_HOURS");

                entity.Property(e => e.SupervisorAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPERVISOR_ASSIGNMENT_ID");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.TimeNormalFinish)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_FINISH");

                entity.Property(e => e.TimeNormalStart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_START");

                entity.Property(e => e.UnionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UNION_ID");

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_HOURS");
            });

            modelBuilder.Entity<HrAllPositionsFVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ALL_POSITIONS_F_VL", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.AssignmentCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_CATEGORY");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE16");

                entity.Property(e => e.Attribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE17");

                entity.Property(e => e.Attribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE18");

                entity.Property(e => e.Attribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE19");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE20");

                entity.Property(e => e.Attribute21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE21");

                entity.Property(e => e.Attribute22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE22");

                entity.Property(e => e.Attribute23)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE23");

                entity.Property(e => e.Attribute24)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE24");

                entity.Property(e => e.Attribute25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE25");

                entity.Property(e => e.Attribute26)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE26");

                entity.Property(e => e.Attribute27)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE27");

                entity.Property(e => e.Attribute28)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE28");

                entity.Property(e => e.Attribute29)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE29");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute30)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE30");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AttributeDate1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE1");

                entity.Property(e => e.AttributeDate10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE10");

                entity.Property(e => e.AttributeDate11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE11");

                entity.Property(e => e.AttributeDate12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE12");

                entity.Property(e => e.AttributeDate13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE13");

                entity.Property(e => e.AttributeDate14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE14");

                entity.Property(e => e.AttributeDate15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE15");

                entity.Property(e => e.AttributeDate2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE2");

                entity.Property(e => e.AttributeDate3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE3");

                entity.Property(e => e.AttributeDate4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE4");

                entity.Property(e => e.AttributeDate5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE5");

                entity.Property(e => e.AttributeDate6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE6");

                entity.Property(e => e.AttributeDate7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE7");

                entity.Property(e => e.AttributeDate8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE8");

                entity.Property(e => e.AttributeDate9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE9");

                entity.Property(e => e.AttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER1");

                entity.Property(e => e.AttributeNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER10");

                entity.Property(e => e.AttributeNumber11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER11");

                entity.Property(e => e.AttributeNumber12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER12");

                entity.Property(e => e.AttributeNumber13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER13");

                entity.Property(e => e.AttributeNumber14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER14");

                entity.Property(e => e.AttributeNumber15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER15");

                entity.Property(e => e.AttributeNumber16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER16");

                entity.Property(e => e.AttributeNumber17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER17");

                entity.Property(e => e.AttributeNumber18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER18");

                entity.Property(e => e.AttributeNumber19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER19");

                entity.Property(e => e.AttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER2");

                entity.Property(e => e.AttributeNumber20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER20");

                entity.Property(e => e.AttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER3");

                entity.Property(e => e.AttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER4");

                entity.Property(e => e.AttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER5");

                entity.Property(e => e.AttributeNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER6");

                entity.Property(e => e.AttributeNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER7");

                entity.Property(e => e.AttributeNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER8");

                entity.Property(e => e.AttributeNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER9");

                entity.Property(e => e.BargainingUnitCd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BARGAINING_UNIT_CD");

                entity.Property(e => e.BudgetAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_AMOUNT");

                entity.Property(e => e.BudgetAmountCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGET_AMOUNT_CURRENCY");

                entity.Property(e => e.BudgetedPositionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUDGETED_POSITION_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_UNIT_ID");

                entity.Property(e => e.CalculateFte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALCULATE_FTE");

                entity.Property(e => e.CollectiveAgreementId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COLLECTIVE_AGREEMENT_ID");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COST_CENTER");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DelegatePositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DELEGATE_POSITION_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EntryGradeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTRY_GRADE_ID");

                entity.Property(e => e.EntryStepId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTRY_STEP_ID");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Fte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTE");

                entity.Property(e => e.FullPartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_PART_TIME");

                entity.Property(e => e.FundedByExistingPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNDED_BY_EXISTING_POSITION");

                entity.Property(e => e.GradeLadderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_LADDER_ID");

                entity.Property(e => e.HiringStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HIRING_STATUS");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.MaxPersons)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAX_PERSONS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.OverlapAllowed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OVERLAP_ALLOWED");

                entity.Property(e => e.PermanentTemporaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERMANENT_TEMPORARY_FLAG");

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_CODE");

                entity.Property(e => e.PositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_ID");

                entity.Property(e => e.PositionSynchronizationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_SYNCHRONIZATION_FLAG");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_TYPE");

                entity.Property(e => e.ProbationPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_PERIOD");

                entity.Property(e => e.ProbationPeriodUnitCd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_PERIOD_UNIT_CD");

                entity.Property(e => e.RequisitionTemplateId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUISITION_TEMPLATE_ID");

                entity.Property(e => e.SeasonalEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SEASONAL_END_DATE");

                entity.Property(e => e.SeasonalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEASONAL_FLAG");

                entity.Property(e => e.SeasonalStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SEASONAL_START_DATE");

                entity.Property(e => e.SecurityClearance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURITY_CLEARANCE");

                entity.Property(e => e.StandardWorkingFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STANDARD_WORKING_FREQUENCY");

                entity.Property(e => e.StandardWorkingHours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STANDARD_WORKING_HOURS");

                entity.Property(e => e.SupervisorAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPERVISOR_ASSIGNMENT_ID");

                entity.Property(e => e.SupervisorId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.TimeNormalFinish)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_FINISH");

                entity.Property(e => e.TimeNormalStart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_START");

                entity.Property(e => e.UnionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UNION_ID");

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_HOURS");
            });

            modelBuilder.Entity<HrLocationsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LOCATIONS_ALL", "FUSION");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CREATED_BY_USER_ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdatedByUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATED_BY_USER_ID");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.PDateFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("_P_DATE_FROM");

                entity.Property(e => e.PDateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("_P_DATE_TO");
            });

            modelBuilder.Entity<HrLocationsAllFVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_LOCATIONS_ALL_F_VL", "FUSION");

                entity.Property(e => e.AcLocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AC_LOCATION_CODE");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.AddInformation11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION11");

                entity.Property(e => e.AddInformation12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION12");

                entity.Property(e => e.AddInformation13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION13");

                entity.Property(e => e.AddInformation14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION14");

                entity.Property(e => e.AddInformation15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION15");

                entity.Property(e => e.AddInformation16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION16");

                entity.Property(e => e.AddInformation17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION17");

                entity.Property(e => e.AddInformation18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION18");

                entity.Property(e => e.AddInformation19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION19");

                entity.Property(e => e.AddInformation20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_INFORMATION20");

                entity.Property(e => e.AddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ADDRESS_ID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_2");

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_3");

                entity.Property(e => e.AddressLine4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_4");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE16");

                entity.Property(e => e.Attribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE17");

                entity.Property(e => e.Attribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE18");

                entity.Property(e => e.Attribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE19");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE20");

                entity.Property(e => e.Attribute21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE21");

                entity.Property(e => e.Attribute22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE22");

                entity.Property(e => e.Attribute23)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE23");

                entity.Property(e => e.Attribute24)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE24");

                entity.Property(e => e.Attribute25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE25");

                entity.Property(e => e.Attribute26)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE26");

                entity.Property(e => e.Attribute27)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE27");

                entity.Property(e => e.Attribute28)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE28");

                entity.Property(e => e.Attribute29)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE29");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute30)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE30");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AttributeDate1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE1");

                entity.Property(e => e.AttributeDate10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE10");

                entity.Property(e => e.AttributeDate11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE11");

                entity.Property(e => e.AttributeDate12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE12");

                entity.Property(e => e.AttributeDate13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE13");

                entity.Property(e => e.AttributeDate14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE14");

                entity.Property(e => e.AttributeDate15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE15");

                entity.Property(e => e.AttributeDate2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE2");

                entity.Property(e => e.AttributeDate3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE3");

                entity.Property(e => e.AttributeDate4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE4");

                entity.Property(e => e.AttributeDate5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE5");

                entity.Property(e => e.AttributeDate6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE6");

                entity.Property(e => e.AttributeDate7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE7");

                entity.Property(e => e.AttributeDate8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE8");

                entity.Property(e => e.AttributeDate9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_DATE9");

                entity.Property(e => e.AttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER1");

                entity.Property(e => e.AttributeNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER10");

                entity.Property(e => e.AttributeNumber11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER11");

                entity.Property(e => e.AttributeNumber12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER12");

                entity.Property(e => e.AttributeNumber13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER13");

                entity.Property(e => e.AttributeNumber14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER14");

                entity.Property(e => e.AttributeNumber15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER15");

                entity.Property(e => e.AttributeNumber16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER16");

                entity.Property(e => e.AttributeNumber17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER17");

                entity.Property(e => e.AttributeNumber18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER18");

                entity.Property(e => e.AttributeNumber19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER19");

                entity.Property(e => e.AttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER2");

                entity.Property(e => e.AttributeNumber20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER20");

                entity.Property(e => e.AttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER3");

                entity.Property(e => e.AttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER4");

                entity.Property(e => e.AttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER5");

                entity.Property(e => e.AttributeNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER6");

                entity.Property(e => e.AttributeNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER7");

                entity.Property(e => e.AttributeNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER8");

                entity.Property(e => e.AttributeNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER9");

                entity.Property(e => e.BillToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILL_TO_SITE_FLAG");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.BusinessGroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DerivedLocale)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DERIVED_LOCALE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DesignatedReceiverId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DESIGNATED_RECEIVER_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.FaxAreaCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_AREA_CODE2");

                entity.Property(e => e.FaxCountryCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_COUNTRY_CODE2");

                entity.Property(e => e.FaxExtension2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_EXTENSION2");

                entity.Property(e => e.FaxSubscriberNum2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_SUBSCRIBER_NUM2");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLOOR_NUMBER");

                entity.Property(e => e.GeoHierarchyNodeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GEO_HIERARCHY_NODE_ID");

                entity.Property(e => e.GeoHierarchyNodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEO_HIERARCHY_NODE_VALUE");

                entity.Property(e => e.Geometry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEOMETRY");

                entity.Property(e => e.InternalLocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_LOCATION_CODE");

                entity.Property(e => e.InventoryOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INVENTORY_ORGANIZATION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocInformation13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION13");

                entity.Property(e => e.LocInformation14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION14");

                entity.Property(e => e.LocInformation15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION15");

                entity.Property(e => e.LocInformation16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION16");

                entity.Property(e => e.LocInformation17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION17");

                entity.Property(e => e.LocInformation18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION18");

                entity.Property(e => e.LocInformation19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION19");

                entity.Property(e => e.LocInformation20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION20");

                entity.Property(e => e.LocInformation21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION21");

                entity.Property(e => e.LocInformation22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_INFORMATION22");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationDetailsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_DETAILS_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.LocationImageUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_IMAGE_URL");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.LongPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LONG_POSTAL_CODE");

                entity.Property(e => e.MainphoneAreaCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_AREA_CODE1");

                entity.Property(e => e.MainphoneCountryCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_COUNTRY_CODE1");

                entity.Property(e => e.MainphoneExtension1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_EXTENSION1");

                entity.Property(e => e.MainphoneSubscriberNum1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_SUBSCRIBER_NUM1");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OfficeSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICE_SITE_FLAG");

                entity.Property(e => e.OfficialLanguageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICIAL_LANGUAGE_CODE");

                entity.Property(e => e.OtherphoneAreaCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_AREA_CODE3");

                entity.Property(e => e.OtherphoneCountryCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_COUNTRY_CODE3");

                entity.Property(e => e.OtherphoneExtension3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_EXTENSION3");

                entity.Property(e => e.OtherphoneSubscriberNum3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_SUBSCRIBER_NUM3");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTAL_CODE");

                entity.Property(e => e.ReceivingSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_SITE_FLAG");

                entity.Property(e => e.Region1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGION_1");

                entity.Property(e => e.Region2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGION_2");

                entity.Property(e => e.Region3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGION_3");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.ShipToLocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SHIP_TO_LOCATION_ID");

                entity.Property(e => e.ShipToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_TO_SITE_FLAG");

                entity.Property(e => e.Style)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STYLE");

                entity.Property(e => e.TelephoneNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_1");

                entity.Property(e => e.TelephoneNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_2");

                entity.Property(e => e.TelephoneNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_3");

                entity.Property(e => e.TimezoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIMEZONE_CODE");

                entity.Property(e => e.TownOrCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOWN_OR_CITY");
            });

            modelBuilder.Entity<HrOperatingUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_OPERATING_UNITS", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.DefaultLegalContextId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_LEGAL_CONTEXT_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SetOfBooksId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_OF_BOOKS_ID");

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_CODE");

                entity.Property(e => e.UsableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USABLE_FLAG");
            });

            modelBuilder.Entity<HrOrgDetailsByClassV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ORG_DETAILS_BY_CLASS_V", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.OrgInformation2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORG_INFORMATION2");

                entity.Property(e => e.OrgInformation3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORG_INFORMATION3");

                entity.Property(e => e.OrgInformationContext)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORG_INFORMATION_CONTEXT");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SequenceNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEQUENCE_NUMBER");
            });

            modelBuilder.Entity<HrOrgUnitClassificationsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ORG_UNIT_CLASSIFICATIONS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrgUnitClassificationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORG_UNIT_CLASSIFICATION_ID");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<HrOrganizationUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ORGANIZATION_UNITS", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CostAllocationKeyflexId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST_ALLOCATION_KEYFLEX_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.InternalAddressLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_ADDRESS_LINE");

                entity.Property(e => e.InternalExternalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_EXTERNAL_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<HrOrganizationV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_ORGANIZATION_V", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ESTABLISHMENT_ID");

                entity.Property(e => e.InternalAddressLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_ADDRESS_LINE");

                entity.Property(e => e.InternalExternalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_EXTERNAL_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_CODE");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<InvOrgParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_ORG_PARAMETERS", "FUSION");

                entity.Property(e => e.AllocateSerialFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOCATE_SERIAL_FLAG");

                entity.Property(e => e.AllowDifferentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DIFFERENT_STATUS");

                entity.Property(e => e.AllowNegOnhandCcTxns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_NEG_ONHAND_CC_TXNS");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AttributeDate1)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE1");

                entity.Property(e => e.AttributeDate2)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE2");

                entity.Property(e => e.AttributeDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE3");

                entity.Property(e => e.AttributeDate4)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE4");

                entity.Property(e => e.AttributeDate5)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE5");

                entity.Property(e => e.AttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER1");

                entity.Property(e => e.AttributeNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER10");

                entity.Property(e => e.AttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER2");

                entity.Property(e => e.AttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER3");

                entity.Property(e => e.AttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER4");

                entity.Property(e => e.AttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER5");

                entity.Property(e => e.AttributeNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER6");

                entity.Property(e => e.AttributeNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER7");

                entity.Property(e => e.AttributeNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER8");

                entity.Property(e => e.AttributeNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER9");

                entity.Property(e => e.AttributeTimestamp1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_TIMESTAMP1");

                entity.Property(e => e.AttributeTimestamp2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_TIMESTAMP2");

                entity.Property(e => e.AttributeTimestamp3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_TIMESTAMP3");

                entity.Property(e => e.AttributeTimestamp4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_TIMESTAMP4");

                entity.Property(e => e.AttributeTimestamp5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_TIMESTAMP5");

                entity.Property(e => e.AutoBreakdownEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_BREAKDOWN_ENABLED");

                entity.Property(e => e.AutoDelAllocFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_DEL_ALLOC_FLAG");

                entity.Property(e => e.AutoLotAlphaPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_LOT_ALPHA_PREFIX");

                entity.Property(e => e.AutoSerialAlphaPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_SERIAL_ALPHA_PREFIX");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_UNIT_ID");

                entity.Property(e => e.CapturePickingException)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAPTURE_PICKING_EXCEPTION");

                entity.Property(e => e.CartonizationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARTONIZATION_FLAG");

                entity.Property(e => e.ChildLotAlphaPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_LOT_ALPHA_PREFIX");

                entity.Property(e => e.ChildLotNumberLength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_LOT_NUMBER_LENGTH");

                entity.Property(e => e.ChildLotValidationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_LOT_VALIDATION_FLAG");

                entity.Property(e => e.ChildLotZeroPaddingFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_LOT_ZERO_PADDING_FLAG");

                entity.Property(e => e.ContractMfgFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_MFG_FLAG");

                entity.Property(e => e.CopyLotAttributeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPY_LOT_ATTRIBUTE_FLAG");

                entity.Property(e => e.CreateLotUomConversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_LOT_UOM_CONVERSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CrossdockFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CROSSDOCK_FLAG");

                entity.Property(e => e.CustomerAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ACCOUNT_NUMBER");

                entity.Property(e => e.DefaultCartonRuleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_CARTON_RULE_ID");

                entity.Property(e => e.DefaultCycCountHeaderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_CYC_COUNT_HEADER_ID");

                entity.Property(e => e.DefaultLocatorOrderValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_LOCATOR_ORDER_VALUE");

                entity.Property(e => e.DefaultPickingRuleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_PICKING_RULE_ID");

                entity.Property(e => e.DefaultPutAwayRuleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_PUT_AWAY_RULE_ID");

                entity.Property(e => e.DefaultSubinvOrderValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_SUBINV_ORDER_VALUE");

                entity.Property(e => e.DefaultWmsPickingRuleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_WMS_PICKING_RULE_ID");

                entity.Property(e => e.DistributedOrganizationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTRIBUTED_ORGANIZATION_FLAG");

                entity.Property(e => e.EamEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EAM_ENABLED_FLAG");

                entity.Property(e => e.EnforceLocatorAlisUnqFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENFORCE_LOCATOR_ALIS_UNQ_FLAG");

                entity.Property(e => e.FifoOrigRcptDateFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIFO_ORIG_RCPT_DATE_FLAG");

                entity.Property(e => e.FillKillMoveOrderFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILL_KILL_MOVE_ORDER_FLAG");

                entity.Property(e => e.FillKillTransferOrdersFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILL_KILL_TRANSFER_ORDERS_FLAG");

                entity.Property(e => e.GlobalAttribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE1");

                entity.Property(e => e.GlobalAttribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE10");

                entity.Property(e => e.GlobalAttribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE11");

                entity.Property(e => e.GlobalAttribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE12");

                entity.Property(e => e.GlobalAttribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE13");

                entity.Property(e => e.GlobalAttribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE14");

                entity.Property(e => e.GlobalAttribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE15");

                entity.Property(e => e.GlobalAttribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE16");

                entity.Property(e => e.GlobalAttribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE17");

                entity.Property(e => e.GlobalAttribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE18");

                entity.Property(e => e.GlobalAttribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE19");

                entity.Property(e => e.GlobalAttribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE2");

                entity.Property(e => e.GlobalAttribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE20");

                entity.Property(e => e.GlobalAttribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE3");

                entity.Property(e => e.GlobalAttribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE4");

                entity.Property(e => e.GlobalAttribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE5");

                entity.Property(e => e.GlobalAttribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE6");

                entity.Property(e => e.GlobalAttribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE7");

                entity.Property(e => e.GlobalAttribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE8");

                entity.Property(e => e.GlobalAttribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE9");

                entity.Property(e => e.GlobalAttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_ATTRIBUTE_CATEGORY");

                entity.Property(e => e.GroupingJobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GROUPING_JOB_ID");

                entity.Property(e => e.GroupingJobStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GROUPING_JOB_STATUS");

                entity.Property(e => e.IntegratedSystemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTEGRATED_SYSTEM_CODE");

                entity.Property(e => e.InternalCustomerFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_CUSTOMER_FLAG");

                entity.Property(e => e.InventoryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVENTORY_FLAG");

                entity.Property(e => e.ItemDefinitionOrgId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITEM_DEFINITION_ORG_ID");

                entity.Property(e => e.ItemGroupingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_GROUPING_CODE");

                entity.Property(e => e.JobDefinitionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_DEFINITION_NAME");

                entity.Property(e => e.JobDefinitionPackage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_DEFINITION_PACKAGE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LotNumberLength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT_NUMBER_LENGTH");

                entity.Property(e => e.LotNumberUniqueness)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT_NUMBER_UNIQUENESS");

                entity.Property(e => e.LotNumberZeroPadding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOT_NUMBER_ZERO_PADDING");

                entity.Property(e => e.LpnPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LPN_PREFIX");

                entity.Property(e => e.LpnStartingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LPN_STARTING_NUMBER");

                entity.Property(e => e.LpnSuffix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LPN_SUFFIX");

                entity.Property(e => e.MaintOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAINT_ORGANIZATION_ID");

                entity.Property(e => e.ManualReceiptExpAtDest)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANUAL_RECEIPT_EXP_AT_DEST");

                entity.Property(e => e.MasterOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MASTER_ORGANIZATION_ID");

                entity.Property(e => e.MfgPlantFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MFG_PLANT_FLAG");

                entity.Property(e => e.MoPickConfirmRequired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MO_PICK_CONFIRM_REQUIRED");

                entity.Property(e => e.NegativeInvReceiptCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEGATIVE_INV_RECEIPT_CODE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_CODE");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.OvpkTransferOrdersEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OVPK_TRANSFER_ORDERS_ENABLED");

                entity.Property(e => e.ParentChildGenerationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CHILD_GENERATION_FLAG");

                entity.Property(e => e.PartyId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARTY_ID");

                entity.Property(e => e.PickQtyDefaultReasonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PICK_QTY_DEFAULT_REASON_ID");

                entity.Property(e => e.PickSlipBatchSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PICK_SLIP_BATCH_SIZE");

                entity.Property(e => e.PmCostCollectionEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PM_COST_COLLECTION_ENABLED");

                entity.Property(e => e.PreFillPickedQty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRE_FILL_PICKED_QTY");

                entity.Property(e => e.PregenPutawayTasksFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREGEN_PUTAWAY_TASKS_FLAG");

                entity.Property(e => e.ProfitCenterBuId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROFIT_CENTER_BU_ID");

                entity.Property(e => e.ProjectControlLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_CONTROL_LEVEL");

                entity.Property(e => e.ProjectReferenceEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_REFERENCE_ENABLED");

                entity.Property(e => e.PurchasingByRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PURCHASING_BY_REVISION");

                entity.Property(e => e.QaSkippingInspFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QA_SKIPPING_INSP_FLAG");

                entity.Property(e => e.RegenerationInterval)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGENERATION_INTERVAL");

                entity.Property(e => e.ReplnshMoveOrderGrouping)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPLNSH_MOVE_ORDER_GROUPING");

                entity.Property(e => e.RequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.RoundReorderQtyFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROUND_REORDER_QTY_FLAG");

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SCHEDULE_ID");

                entity.Property(e => e.SerialNumberGeneration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER_GENERATION");

                entity.Property(e => e.SerialNumberType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER_TYPE");

                entity.Property(e => e.SourceOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SOURCE_ORGANIZATION_ID");

                entity.Property(e => e.SourceSubinventory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_SUBINVENTORY");

                entity.Property(e => e.SourceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TYPE");

                entity.Property(e => e.StandardPackEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STANDARD_PACK_ENABLED");

                entity.Property(e => e.StartAutoSerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("START_AUTO_SERIAL_NUMBER");

                entity.Property(e => e.StartingRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STARTING_REVISION");

                entity.Property(e => e.StockLocatorControlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STOCK_LOCATOR_CONTROL_CODE");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPPLIER_ID");

                entity.Property(e => e.SupplierSiteId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SUPPLIER_SITE_ID");

                entity.Property(e => e.TimezoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIMEZONE_CODE");

                entity.Property(e => e.TimezoneId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TIMEZONE_ID");

                entity.Property(e => e.TotalLpnLength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_LPN_LENGTH");

                entity.Property(e => e.TrackCountryOfOriginFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRACK_COUNTRY_OF_ORIGIN_FLAG");

                entity.Property(e => e.TradingPartnerOrgFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRADING_PARTNER_ORG_FLAG");

                entity.Property(e => e.Ucc128SuffixFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UCC_128_SUFFIX_FLAG");

                entity.Property(e => e.UseCurItemCostFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USE_CUR_ITEM_COST_FLAG");

                entity.Property(e => e.WcsEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WCS_ENABLED");

                entity.Property(e => e.WmsEnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WMS_ENABLED_FLAG");
            });

            modelBuilder.Entity<PayFlwSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAY_FLW_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.FlwSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FLW_SECURITY_PROFILE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PayPaySecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAY_PAY_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PaySecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PAY_SECURITY_PROFILE_ID");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerAllAssignmentsM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ALL_ASSIGNMENTS_M", "FUSION");

                entity.Property(e => e.ActionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_CODE");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.AllowAsgOverrideFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_ASG_OVERRIDE_FLAG");

                entity.Property(e => e.ApplicantRank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLICANT_RANK");

                entity.Property(e => e.AssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_ID");

                entity.Property(e => e.AssignmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_NAME");

                entity.Property(e => e.AssignmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_NUMBER");

                entity.Property(e => e.AssignmentSequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_SEQUENCE");

                entity.Property(e => e.AssignmentStatusType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_STATUS_TYPE");

                entity.Property(e => e.AssignmentStatusTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_STATUS_TYPE_ID");

                entity.Property(e => e.AssignmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_TYPE");

                entity.Property(e => e.AutoEndFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_END_FLAG");

                entity.Property(e => e.BargainingUnitCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BARGAINING_UNIT_CODE");

                entity.Property(e => e.BillingTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_TITLE");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_UNIT_ID");

                entity.Property(e => e.CagrGradeDefId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CAGR_GRADE_DEF_ID");

                entity.Property(e => e.CagrIdFlexNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAGR_ID_FLEX_NUM");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.CollectiveAgreementId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COLLECTIVE_AGREEMENT_ID");

                entity.Property(e => e.ContractId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONTRACT_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateProbationEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATE_PROBATION_END");

                entity.Property(e => e.DefaultCodeCombId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEFAULT_CODE_COMB_ID");

                entity.Property(e => e.DutiesType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DUTIES_TYPE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveLatestChange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EFFECTIVE_LATEST_CHANGE");

                entity.Property(e => e.EffectiveSequence)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("EFFECTIVE_SEQUENCE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EmployeeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_CATEGORY");

                entity.Property(e => e.EmploymentCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYMENT_CATEGORY");

                entity.Property(e => e.EstablishmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ESTABLISHMENT_ID");

                entity.Property(e => e.ExpenseCheckAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPENSE_CHECK_ADDRESS");

                entity.Property(e => e.FreezeStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("FREEZE_START_DATE");

                entity.Property(e => e.FreezeUntilDate)
                    .HasColumnType("DATE")
                    .HasColumnName("FREEZE_UNTIL_DATE");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.FullPartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_PART_TIME");

                entity.Property(e => e.GradeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_ID");

                entity.Property(e => e.GradeLadderPgmId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_LADDER_PGM_ID");

                entity.Property(e => e.GspEligibilityFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSP_ELIGIBILITY_FLAG");

                entity.Property(e => e.HourlySalariedCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOURLY_SALARIED_CODE");

                entity.Property(e => e.IdFlexNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_FLEX_NUM");

                entity.Property(e => e.InternalBuilding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_BUILDING");

                entity.Property(e => e.InternalFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_FLOOR");

                entity.Property(e => e.InternalLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_LOCATION");

                entity.Property(e => e.InternalMailstop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_MAILSTOP");

                entity.Property(e => e.InternalOfficeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INTERNAL_OFFICE_NUMBER");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.JobPostSourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_POST_SOURCE_NAME");

                entity.Property(e => e.LabourUnionMemberFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LABOUR_UNION_MEMBER_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.LinkageType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINKAGE_TYPE");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_FLAG");

                entity.Property(e => e.NormalHours)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NORMAL_HOURS");

                entity.Property(e => e.NoticePeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTICE_PERIOD");

                entity.Property(e => e.NoticePeriodUom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTICE_PERIOD_UOM");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.OvertimePeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OVERTIME_PERIOD");

                entity.Property(e => e.ParentAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENT_ASSIGNMENT_ID");

                entity.Property(e => e.PeopleGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PEOPLE_GROUP_ID");

                entity.Property(e => e.PeriodOfServiceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERIOD_OF_SERVICE_ID");

                entity.Property(e => e.PermanentTemporaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERMANENT_TEMPORARY_FLAG");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonReferredById)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_REFERRED_BY_ID");

                entity.Property(e => e.PersonTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.PoHeaderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PO_HEADER_ID");

                entity.Property(e => e.PoLineId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PO_LINE_ID");

                entity.Property(e => e.PositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_ID");

                entity.Property(e => e.PositionOverrideFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_OVERRIDE_FLAG");

                entity.Property(e => e.PostingContentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSTING_CONTENT_ID");

                entity.Property(e => e.PrimaryAssignmentFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_ASSIGNMENT_FLAG");

                entity.Property(e => e.PrimaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_FLAG");

                entity.Property(e => e.PrimaryWorkRelationFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_WORK_RELATION_FLAG");

                entity.Property(e => e.PrimaryWorkTermsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_WORK_TERMS_FLAG");

                entity.Property(e => e.ProbationPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_PERIOD");

                entity.Property(e => e.ProbationUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBATION_UNIT");

                entity.Property(e => e.ProjectTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT_TITLE");

                entity.Property(e => e.ProjectedAssignmentEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTED_ASSIGNMENT_END");

                entity.Property(e => e.ProjectedStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROJECTED_START_DATE");

                entity.Property(e => e.ProposedWorkerType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROPOSED_WORKER_TYPE");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REASON_CODE");

                entity.Property(e => e.RecordCreator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_CREATOR");

                entity.Property(e => e.RecruiterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RECRUITER_ID");

                entity.Property(e => e.RecruitmentActivityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RECRUITMENT_ACTIVITY_ID");

                entity.Property(e => e.RetirementAge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RETIREMENT_AGE");

                entity.Property(e => e.RetirementDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETIREMENT_DATE");

                entity.Property(e => e.SalReviewPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAL_REVIEW_PERIOD");

                entity.Property(e => e.SalReviewPeriodFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAL_REVIEW_PERIOD_FREQUENCY");

                entity.Property(e => e.SeniorityBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SENIORITY_BASIS");

                entity.Property(e => e.SetOfBooksId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_OF_BOOKS_ID");

                entity.Property(e => e.SoftCodingKeyflexId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SOFT_CODING_KEYFLEX_ID");

                entity.Property(e => e.SourceAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SOURCE_ASSIGNMENT_ID");

                entity.Property(e => e.SourceOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SOURCE_ORGANIZATION_ID");

                entity.Property(e => e.SourceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TYPE");

                entity.Property(e => e.SpecialCeilingStepId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SPECIAL_CEILING_STEP_ID");

                entity.Property(e => e.StepEntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("STEP_ENTRY_DATE");

                entity.Property(e => e.SystemPersonType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_PERSON_TYPE");

                entity.Property(e => e.TaxAddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TAX_ADDRESS_ID");

                entity.Property(e => e.TimeNormalFinish)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_FINISH");

                entity.Property(e => e.TimeNormalStart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_NORMAL_START");

                entity.Property(e => e.UnionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("UNION_ID");

                entity.Property(e => e.VacancyId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("VACANCY_ID");

                entity.Property(e => e.VendorAssignmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VENDOR_ASSIGNMENT_NUMBER");

                entity.Property(e => e.VendorEmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VENDOR_EMPLOYEE_NUMBER");

                entity.Property(e => e.VendorId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("VENDOR_ID");

                entity.Property(e => e.VendorSiteId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("VENDOR_SITE_ID");

                entity.Property(e => e.WorkAtHome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORK_AT_HOME");

                entity.Property(e => e.WorkTermsAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WORK_TERMS_ASSIGNMENT_ID");
            });

            modelBuilder.Entity<PerAllPeopleF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ALL_PEOPLE_F", "FUSION");

                entity.Property(e => e.ApplicantNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLICANT_NUMBER");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MailingAddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAILING_ADDRESS_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERSON_NUMBER");

                entity.Property(e => e.PrimaryEmailId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_EMAIL_ID");

                entity.Property(e => e.PrimaryNidId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_NID_ID");

                entity.Property(e => e.PrimaryNidNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_NID_NUMBER");

                entity.Property(e => e.PrimaryPhoneId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRIMARY_PHONE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.WaiveDataProtect)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WAIVE_DATA_PROTECT");
            });

            modelBuilder.Entity<PerAssignmentSupervisorsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ASSIGNMENT_SUPERVISORS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.AssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_ID");

                entity.Property(e => e.AssignmentSupervisorId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_SUPERVISOR_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.FreezeStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("FREEZE_START_DATE");

                entity.Property(e => e.FreezeUntilDate)
                    .HasColumnType("DATE")
                    .HasColumnName("FREEZE_UNTIL_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ManagerAssignmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MANAGER_ASSIGNMENT_ID");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.ManagerType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_TYPE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.PrimaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_FLAG");

                entity.Property(e => e.WorkingPercentage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_PERCENTAGE");
            });

            modelBuilder.Entity<PerCountrySecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_COUNTRY_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CountrySecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COUNTRY_SECURITY_PROFILE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_DEPARTMENTS", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORGANIZATION_CODE");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<PerDocTypeSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_DOC_TYPE_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DocTypeSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DOC_TYPE_SECURITY_PROFILE_ID");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.IncludeExcludeFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_EXCLUDE_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerGenDataRoleProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_GEN_DATA_ROLE_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.GenDataRoleProfilesId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GEN_DATA_ROLE_PROFILES_ID");

                entity.Property(e => e.GeneratedDataRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GENERATED_DATA_ROLE_ID");

                entity.Property(e => e.HrSecuringObject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HR_SECURING_OBJECT");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SECURITY_PROFILE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerGeneratedDataRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_GENERATED_DATA_ROLES", "FUSION");

                entity.Property(e => e.AppRoleDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("APP_ROLE_DESCRIPTION");

                entity.Property(e => e.AppRoleDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APP_ROLE_DISPLAY_NAME");

                entity.Property(e => e.AppRoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APP_ROLE_NAME");

                entity.Property(e => e.BaseRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BASE_ROLE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataRoleDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DATA_ROLE_DESCRIPTION");

                entity.Property(e => e.DataRoleDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATA_ROLE_DISPLAY_NAME");

                entity.Property(e => e.DataRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DATA_ROLE_ID");

                entity.Property(e => e.DataRoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DATA_ROLE_NAME");

                entity.Property(e => e.DelegationAllowed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELEGATION_ALLOWED");

                entity.Property(e => e.GeneratedDataRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GENERATED_DATA_ROLE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");
            });

            modelBuilder.Entity<PerGradesF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_GRADES_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.CeilingStepId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CEILING_STEP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.GradeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_CODE");

                entity.Property(e => e.GradeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_ID");

                entity.Property(e => e.GradeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_TYPE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PayScaleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PAY_SCALE_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.StartingStep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STARTING_STEP");
            });

            modelBuilder.Entity<PerJobsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_JOBS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.ApprovalAuthority)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_AUTHORITY");

                entity.Property(e => e.BenchmarkJobFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BENCHMARK_JOB_FLAG");

                entity.Property(e => e.BenchmarkJobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BENCHMARK_JOB_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.FullPartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_PART_TIME");

                entity.Property(e => e.GradeLadderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_LADDER_ID");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_CODE");

                entity.Property(e => e.JobFamilyId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_FAMILY_ID");

                entity.Property(e => e.JobFunctionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_FUNCTION_CODE");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ManagerLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_LEVEL");

                entity.Property(e => e.MedCheckupReq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MED_CHECKUP_REQ");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.ProgressionJobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROGRESSION_JOB_ID");

                entity.Property(e => e.RegularTemporary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGULAR_TEMPORARY");

                entity.Property(e => e.RequisitionTemplateId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUISITION_TEMPLATE_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SET_ID");
            });

            modelBuilder.Entity<PerLdapUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LDAP_USERS", "FUSION");

                entity.Property(e => e.AtompubId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATOMPUB_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.Commonname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMMONNAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CredentialsEmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREDENTIALS_EMAIL_ADDRESS");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LdapRequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LDAP_REQUEST_ID");

                entity.Property(e => e.LdapUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LDAP_USER_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PreferredLanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREFERRED_LANGUAGE");

                entity.Property(e => e.RequestId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_STATUS");

                entity.Property(e => e.RequestType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_TYPE");

                entity.Property(e => e.RequestorUserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTOR_USER_GUID");

                entity.Property(e => e.SendCredentialsEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEND_CREDENTIALS_EMAIL");

                entity.Property(e => e.UserCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_CATEGORY");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GUID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<PerLdgSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LDG_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LdgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LDG_SECURITY_PROFILE_ID");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerLegalEmployer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LEGAL_EMPLOYERS", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<PerLocationDetailsF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LOCATION_DETAILS_F", "FUSION");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.BillToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILL_TO_SITE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DesignatedReceiverId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DESIGNATED_RECEIVER_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.FaxAreaCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_AREA_CODE2");

                entity.Property(e => e.FaxCountryCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_COUNTRY_CODE2");

                entity.Property(e => e.FaxExtension2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_EXTENSION2");

                entity.Property(e => e.FaxSubscriberNum2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_SUBSCRIBER_NUM2");

                entity.Property(e => e.GeoHierarchyNodeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GEO_HIERARCHY_NODE_ID");

                entity.Property(e => e.GeoHierarchyNodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEO_HIERARCHY_NODE_VALUE");

                entity.Property(e => e.InventoryOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INVENTORY_ORGANIZATION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationDetailsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_DETAILS_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.MainAddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAIN_ADDRESS_ID");

                entity.Property(e => e.MainphoneAreaCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_AREA_CODE1");

                entity.Property(e => e.MainphoneAreaCode11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_AREA_CODE11");

                entity.Property(e => e.MainphoneCountryCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_COUNTRY_CODE1");

                entity.Property(e => e.MainphoneExtension1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_EXTENSION1");

                entity.Property(e => e.MainphoneSubscriberNum1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_SUBSCRIBER_NUM1");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OfficeSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICE_SITE_FLAG");

                entity.Property(e => e.OfficialLanguageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICIAL_LANGUAGE_CODE");

                entity.Property(e => e.OtherphoneAreaCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_AREA_CODE3");

                entity.Property(e => e.OtherphoneCountryCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_COUNTRY_CODE3");

                entity.Property(e => e.OtherphoneExtension3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_EXTENSION3");

                entity.Property(e => e.OtherphoneSubscriberNum3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_SUBSCRIBER_NUM3");

                entity.Property(e => e.ReceivingSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_SITE_FLAG");

                entity.Property(e => e.ShipToLocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SHIP_TO_LOCATION_ID");

                entity.Property(e => e.ShipToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_TO_SITE_FLAG");

                entity.Property(e => e.TelephoneNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_1");

                entity.Property(e => e.TelephoneNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_2");

                entity.Property(e => e.TelephoneNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_3");

                entity.Property(e => e.TimezoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIMEZONE_CODE");
            });

            modelBuilder.Entity<PerLocationDetailsFVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LOCATION_DETAILS_F_VL", "FUSION");

                entity.Property(e => e.AcLocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AC_LOCATION_CODE");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE16");

                entity.Property(e => e.Attribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE17");

                entity.Property(e => e.Attribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE18");

                entity.Property(e => e.Attribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE19");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE20");

                entity.Property(e => e.Attribute21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE21");

                entity.Property(e => e.Attribute22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE22");

                entity.Property(e => e.Attribute23)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE23");

                entity.Property(e => e.Attribute24)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE24");

                entity.Property(e => e.Attribute25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE25");

                entity.Property(e => e.Attribute26)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE26");

                entity.Property(e => e.Attribute27)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE27");

                entity.Property(e => e.Attribute28)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE28");

                entity.Property(e => e.Attribute29)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE29");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute30)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE30");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AttributeDate1)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE1");

                entity.Property(e => e.AttributeDate10)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE10");

                entity.Property(e => e.AttributeDate11)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE11");

                entity.Property(e => e.AttributeDate12)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE12");

                entity.Property(e => e.AttributeDate13)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE13");

                entity.Property(e => e.AttributeDate14)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE14");

                entity.Property(e => e.AttributeDate15)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE15");

                entity.Property(e => e.AttributeDate2)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE2");

                entity.Property(e => e.AttributeDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE3");

                entity.Property(e => e.AttributeDate4)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE4");

                entity.Property(e => e.AttributeDate5)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE5");

                entity.Property(e => e.AttributeDate6)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE6");

                entity.Property(e => e.AttributeDate7)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE7");

                entity.Property(e => e.AttributeDate8)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE8");

                entity.Property(e => e.AttributeDate9)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE9");

                entity.Property(e => e.AttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER1");

                entity.Property(e => e.AttributeNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER10");

                entity.Property(e => e.AttributeNumber11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER11");

                entity.Property(e => e.AttributeNumber12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER12");

                entity.Property(e => e.AttributeNumber13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER13");

                entity.Property(e => e.AttributeNumber14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER14");

                entity.Property(e => e.AttributeNumber15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER15");

                entity.Property(e => e.AttributeNumber16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER16");

                entity.Property(e => e.AttributeNumber17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER17");

                entity.Property(e => e.AttributeNumber18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER18");

                entity.Property(e => e.AttributeNumber19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER19");

                entity.Property(e => e.AttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER2");

                entity.Property(e => e.AttributeNumber20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER20");

                entity.Property(e => e.AttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER3");

                entity.Property(e => e.AttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER4");

                entity.Property(e => e.AttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER5");

                entity.Property(e => e.AttributeNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER6");

                entity.Property(e => e.AttributeNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER7");

                entity.Property(e => e.AttributeNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER8");

                entity.Property(e => e.AttributeNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER9");

                entity.Property(e => e.BillToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILL_TO_SITE_FLAG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DesignatedReceiverId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DESIGNATED_RECEIVER_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.FaxAreaCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_AREA_CODE2");

                entity.Property(e => e.FaxCountryCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_COUNTRY_CODE2");

                entity.Property(e => e.FaxExtension2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_EXTENSION2");

                entity.Property(e => e.FaxSubscriberNum2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_SUBSCRIBER_NUM2");

                entity.Property(e => e.GeoHierarchyNodeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GEO_HIERARCHY_NODE_ID");

                entity.Property(e => e.GeoHierarchyNodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEO_HIERARCHY_NODE_VALUE");

                entity.Property(e => e.InventoryOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INVENTORY_ORGANIZATION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationDetailsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_DETAILS_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.MainAddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAIN_ADDRESS_ID");

                entity.Property(e => e.MainphoneAreaCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_AREA_CODE1");

                entity.Property(e => e.MainphoneCountryCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_COUNTRY_CODE1");

                entity.Property(e => e.MainphoneExtension1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_EXTENSION1");

                entity.Property(e => e.MainphoneSubscriberNum1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_SUBSCRIBER_NUM1");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OfficeSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICE_SITE_FLAG");

                entity.Property(e => e.OfficialLanguageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICIAL_LANGUAGE_CODE");

                entity.Property(e => e.OtherphoneAreaCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_AREA_CODE3");

                entity.Property(e => e.OtherphoneCountryCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_COUNTRY_CODE3");

                entity.Property(e => e.OtherphoneExtension3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_EXTENSION3");

                entity.Property(e => e.OtherphoneSubscriberNum3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_SUBSCRIBER_NUM3");

                entity.Property(e => e.ReceivingSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_SITE_FLAG");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.ShipToLocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SHIP_TO_LOCATION_ID");

                entity.Property(e => e.ShipToLocationId1)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SHIP_TO_LOCATION_ID1");

                entity.Property(e => e.ShipToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_TO_SITE_FLAG");

                entity.Property(e => e.TelephoneNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_1");

                entity.Property(e => e.TelephoneNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_2");

                entity.Property(e => e.TelephoneNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_3");

                entity.Property(e => e.TimezoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIMEZONE_CODE");
            });

            modelBuilder.Entity<PerLocationDetailsX>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_LOCATION_DETAILS_X", "FUSION");

                entity.Property(e => e.AcLocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AC_LOCATION_CODE");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_STATUS");

                entity.Property(e => e.BillToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILL_TO_SITE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DesignatedReceiverId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DESIGNATED_RECEIVER_ID");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.FaxAreaCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_AREA_CODE2");

                entity.Property(e => e.FaxCountryCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_COUNTRY_CODE2");

                entity.Property(e => e.FaxExtension2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_EXTENSION2");

                entity.Property(e => e.FaxSubscriberNum2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAX_SUBSCRIBER_NUM2");

                entity.Property(e => e.GeoHierarchyNodeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GEO_HIERARCHY_NODE_ID");

                entity.Property(e => e.GeoHierarchyNodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEO_HIERARCHY_NODE_VALUE");

                entity.Property(e => e.InventoryOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("INVENTORY_ORGANIZATION_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationDetailsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_DETAILS_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.MainAddressId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAIN_ADDRESS_ID");

                entity.Property(e => e.MainphoneAreaCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_AREA_CODE1");

                entity.Property(e => e.MainphoneCountryCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_COUNTRY_CODE1");

                entity.Property(e => e.MainphoneExtension1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_EXTENSION1");

                entity.Property(e => e.MainphoneSubscriberNum1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAINPHONE_SUBSCRIBER_NUM1");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OfficeSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICE_SITE_FLAG");

                entity.Property(e => e.OfficialLanguageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OFFICIAL_LANGUAGE_CODE");

                entity.Property(e => e.OtherphoneAreaCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_AREA_CODE3");

                entity.Property(e => e.OtherphoneCountryCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_COUNTRY_CODE3");

                entity.Property(e => e.OtherphoneExtension3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_EXTENSION3");

                entity.Property(e => e.OtherphoneSubscriberNum3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHERPHONE_SUBSCRIBER_NUM3");

                entity.Property(e => e.ReceivingSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_SITE_FLAG");

                entity.Property(e => e.ShipToLocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SHIP_TO_LOCATION_ID");

                entity.Property(e => e.ShipToSiteFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHIP_TO_SITE_FLAG");

                entity.Property(e => e.TelephoneNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_1");

                entity.Property(e => e.TelephoneNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_2");

                entity.Property(e => e.TelephoneNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NUMBER_3");
            });

            modelBuilder.Entity<PerOrgSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ORG_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.IncludeFutureOrganizations)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_FUTURE_ORGANIZATIONS");

                entity.Property(e => e.IncludeTopOrganization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_TOP_ORGANIZATION");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOC_SECURITY_PROFILE_ID");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrgHierTreeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORG_HIER_TREE_CODE");

                entity.Property(e => e.OrgHierTreeStructCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORG_HIER_TREE_STRUCT_CODE");

                entity.Property(e => e.OrgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORG_SECURITY_PROFILE_ID");

                entity.Property(e => e.SecureByLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_LOCATION");

                entity.Property(e => e.SecureByOrgClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_ORG_CLASS");

                entity.Property(e => e.SecureByOrgHierarchy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_ORG_HIERARCHY");

                entity.Property(e => e.SecureByOrgList)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_ORG_LIST");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.TopOrgSelection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOP_ORG_SELECTION");

                entity.Property(e => e.TopOrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TOP_ORGANIZATION_ID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerPeriodsOfService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_PERIODS_OF_SERVICE", "FUSION");

                entity.Property(e => e.AcceptedTerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACCEPTED_TERMINATION_DATE");

                entity.Property(e => e.ActionOccurrenceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ACTION_OCCURRENCE_ID");

                entity.Property(e => e.ActualTerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTUAL_TERMINATION_DATE");

                entity.Property(e => e.AdjustedSvcDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ADJUSTED_SVC_DATE");

                entity.Property(e => e.Attribute1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE16");

                entity.Property(e => e.Attribute17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE17");

                entity.Property(e => e.Attribute18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE18");

                entity.Property(e => e.Attribute19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE19");

                entity.Property(e => e.Attribute2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE20");

                entity.Property(e => e.Attribute21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE21");

                entity.Property(e => e.Attribute22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE22");

                entity.Property(e => e.Attribute23)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE23");

                entity.Property(e => e.Attribute24)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE24");

                entity.Property(e => e.Attribute25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE25");

                entity.Property(e => e.Attribute26)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE26");

                entity.Property(e => e.Attribute27)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE27");

                entity.Property(e => e.Attribute28)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE28");

                entity.Property(e => e.Attribute29)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE29");

                entity.Property(e => e.Attribute3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute30)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE30");

                entity.Property(e => e.Attribute4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.AttributeCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_CATEGORY");

                entity.Property(e => e.AttributeDate1)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE1");

                entity.Property(e => e.AttributeDate10)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE10");

                entity.Property(e => e.AttributeDate11)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE11");

                entity.Property(e => e.AttributeDate12)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE12");

                entity.Property(e => e.AttributeDate13)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE13");

                entity.Property(e => e.AttributeDate14)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE14");

                entity.Property(e => e.AttributeDate15)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE15");

                entity.Property(e => e.AttributeDate2)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE2");

                entity.Property(e => e.AttributeDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE3");

                entity.Property(e => e.AttributeDate4)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE4");

                entity.Property(e => e.AttributeDate5)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE5");

                entity.Property(e => e.AttributeDate6)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE6");

                entity.Property(e => e.AttributeDate7)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE7");

                entity.Property(e => e.AttributeDate8)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE8");

                entity.Property(e => e.AttributeDate9)
                    .HasColumnType("DATE")
                    .HasColumnName("ATTRIBUTE_DATE9");

                entity.Property(e => e.AttributeNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER1");

                entity.Property(e => e.AttributeNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER10");

                entity.Property(e => e.AttributeNumber11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER11");

                entity.Property(e => e.AttributeNumber12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER12");

                entity.Property(e => e.AttributeNumber13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER13");

                entity.Property(e => e.AttributeNumber14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER14");

                entity.Property(e => e.AttributeNumber15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER15");

                entity.Property(e => e.AttributeNumber16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER16");

                entity.Property(e => e.AttributeNumber17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER17");

                entity.Property(e => e.AttributeNumber18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER18");

                entity.Property(e => e.AttributeNumber19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER19");

                entity.Property(e => e.AttributeNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER2");

                entity.Property(e => e.AttributeNumber20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER20");

                entity.Property(e => e.AttributeNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER3");

                entity.Property(e => e.AttributeNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER4");

                entity.Property(e => e.AttributeNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER5");

                entity.Property(e => e.AttributeNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER6");

                entity.Property(e => e.AttributeNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER7");

                entity.Property(e => e.AttributeNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER8");

                entity.Property(e => e.AttributeNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NUMBER9");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateEmployeeDataVerified)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATE_EMPLOYEE_DATA_VERIFIED");

                entity.Property(e => e.DateStart)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_START");

                entity.Property(e => e.FastPathEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAST_PATH_EMPLOYEE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LastWorkingDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_WORKING_DATE");

                entity.Property(e => e.LegalEntityId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_ENTITY_ID");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.NotifiedTerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NOTIFIED_TERMINATION_DATE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OnMilitaryService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ON_MILITARY_SERVICE");

                entity.Property(e => e.OriginalDateOfHire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL_DATE_OF_HIRE");

                entity.Property(e => e.PdsInformation1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION1");

                entity.Property(e => e.PdsInformation10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION10");

                entity.Property(e => e.PdsInformation11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION11");

                entity.Property(e => e.PdsInformation12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION12");

                entity.Property(e => e.PdsInformation13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION13");

                entity.Property(e => e.PdsInformation14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION14");

                entity.Property(e => e.PdsInformation15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION15");

                entity.Property(e => e.PdsInformation16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION16");

                entity.Property(e => e.PdsInformation17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION17");

                entity.Property(e => e.PdsInformation18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION18");

                entity.Property(e => e.PdsInformation19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION19");

                entity.Property(e => e.PdsInformation2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION2");

                entity.Property(e => e.PdsInformation20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION20");

                entity.Property(e => e.PdsInformation21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION21");

                entity.Property(e => e.PdsInformation22)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION22");

                entity.Property(e => e.PdsInformation23)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION23");

                entity.Property(e => e.PdsInformation24)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION24");

                entity.Property(e => e.PdsInformation25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION25");

                entity.Property(e => e.PdsInformation26)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION26");

                entity.Property(e => e.PdsInformation27)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION27");

                entity.Property(e => e.PdsInformation28)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION28");

                entity.Property(e => e.PdsInformation29)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION29");

                entity.Property(e => e.PdsInformation3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION3");

                entity.Property(e => e.PdsInformation30)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION30");

                entity.Property(e => e.PdsInformation4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION4");

                entity.Property(e => e.PdsInformation5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION5");

                entity.Property(e => e.PdsInformation6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION6");

                entity.Property(e => e.PdsInformation7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION7");

                entity.Property(e => e.PdsInformation8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION8");

                entity.Property(e => e.PdsInformation9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION9");

                entity.Property(e => e.PdsInformationCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_CATEGORY");

                entity.Property(e => e.PdsInformationDate1)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE1");

                entity.Property(e => e.PdsInformationDate10)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE10");

                entity.Property(e => e.PdsInformationDate11)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE11");

                entity.Property(e => e.PdsInformationDate12)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE12");

                entity.Property(e => e.PdsInformationDate13)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE13");

                entity.Property(e => e.PdsInformationDate14)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE14");

                entity.Property(e => e.PdsInformationDate15)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE15");

                entity.Property(e => e.PdsInformationDate2)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE2");

                entity.Property(e => e.PdsInformationDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE3");

                entity.Property(e => e.PdsInformationDate4)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE4");

                entity.Property(e => e.PdsInformationDate5)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE5");

                entity.Property(e => e.PdsInformationDate6)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE6");

                entity.Property(e => e.PdsInformationDate7)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE7");

                entity.Property(e => e.PdsInformationDate8)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE8");

                entity.Property(e => e.PdsInformationDate9)
                    .HasColumnType("DATE")
                    .HasColumnName("PDS_INFORMATION_DATE9");

                entity.Property(e => e.PdsInformationNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER1");

                entity.Property(e => e.PdsInformationNumber10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER10");

                entity.Property(e => e.PdsInformationNumber11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER11");

                entity.Property(e => e.PdsInformationNumber12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER12");

                entity.Property(e => e.PdsInformationNumber13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER13");

                entity.Property(e => e.PdsInformationNumber14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER14");

                entity.Property(e => e.PdsInformationNumber15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER15");

                entity.Property(e => e.PdsInformationNumber16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER16");

                entity.Property(e => e.PdsInformationNumber17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER17");

                entity.Property(e => e.PdsInformationNumber18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER18");

                entity.Property(e => e.PdsInformationNumber19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER19");

                entity.Property(e => e.PdsInformationNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER2");

                entity.Property(e => e.PdsInformationNumber20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER20");

                entity.Property(e => e.PdsInformationNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER3");

                entity.Property(e => e.PdsInformationNumber4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER4");

                entity.Property(e => e.PdsInformationNumber5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER5");

                entity.Property(e => e.PdsInformationNumber6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER6");

                entity.Property(e => e.PdsInformationNumber7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER7");

                entity.Property(e => e.PdsInformationNumber8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER8");

                entity.Property(e => e.PdsInformationNumber9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDS_INFORMATION_NUMBER9");

                entity.Property(e => e.PeriodOfServiceId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERIOD_OF_SERVICE_ID");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_TYPE");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.PrimaryFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_FLAG");

                entity.Property(e => e.ProjectedTerminationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PROJECTED_TERMINATION_DATE");

                entity.Property(e => e.ReadyToConvert)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("READY_TO_CONVERT");

                entity.Property(e => e.RehireAuthorizerPersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REHIRE_AUTHORIZER_PERSON_ID");

                entity.Property(e => e.RehireAuthorizor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REHIRE_AUTHORIZOR");

                entity.Property(e => e.RehireReason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REHIRE_REASON");

                entity.Property(e => e.RehireRecommendation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REHIRE_RECOMMENDATION");

                entity.Property(e => e.RevokeUserAccess)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REVOKE_USER_ACCESS");

                entity.Property(e => e.TerminationAcceptedPersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TERMINATION_ACCEPTED_PERSON_ID");

                entity.Property(e => e.WorkerComments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKER_COMMENTS");

                entity.Property(e => e.WorkerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORKER_NUMBER");
            });

            modelBuilder.Entity<PerPersonNamesF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_PERSON_NAMES_F", "FUSION");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CharSetContext)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHAR_SET_CONTEXT");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_NAME");

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_END_DATE");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EFFECTIVE_START_DATE");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.Honors)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HONORS");

                entity.Property(e => e.KnownAs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KNOWN_AS");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegislationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEGISLATION_CODE");

                entity.Property(e => e.ListName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LIST_NAME");

                entity.Property(e => e.MiddleNames)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MIDDLE_NAMES");

                entity.Property(e => e.MilitaryRank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MILITARY_RANK");

                entity.Property(e => e.NameType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME_TYPE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ORDER_NAME");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.PersonNameId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_NAME_ID");

                entity.Property(e => e.PreNameAdjunct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRE_NAME_ADJUNCT");

                entity.Property(e => e.PreviousLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREVIOUS_LAST_NAME");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUFFIX");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<PerPersonSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_PERSON_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.AccessToCandWithOffer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_TO_CAND_WITH_OFFER");

                entity.Property(e => e.AccessToOwnRecord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_TO_OWN_RECORD");

                entity.Property(e => e.AsgsToEvaluate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASGS_TO_EVALUATE");

                entity.Property(e => e.BuOrgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BU_ORG_SECURITY_PROFILE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CustomRestrictionText)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOM_RESTRICTION_TEXT");

                entity.Property(e => e.DeptOrgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPT_ORG_SECURITY_PROFILE_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnableExclusion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_EXCLUSION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.EvalMgrHierarchyFor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVAL_MGR_HIERARCHY_FOR");

                entity.Property(e => e.GlobalNameRangeEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_NAME_RANGE_END");

                entity.Property(e => e.GlobalNameRangeStart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_NAME_RANGE_START");

                entity.Property(e => e.GradeSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_SECURITY_PROFILE_ID");

                entity.Property(e => e.IncludeFuturePersons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_FUTURE_PERSONS");

                entity.Property(e => e.IncludeRelatedContacts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_RELATED_CONTACTS");

                entity.Property(e => e.IncludeSharedPeopleInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_SHARED_PEOPLE_INFO");

                entity.Property(e => e.JobSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_SECURITY_PROFILE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LdgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LDG_SECURITY_PROFILE_ID");

                entity.Property(e => e.LegEmpOrgSecProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEG_EMP_ORG_SEC_PROFILE_ID");

                entity.Property(e => e.LocationSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_SECURITY_PROFILE_ID");

                entity.Property(e => e.ManagerTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_TYPES");

                entity.Property(e => e.MaxLevelsInHierarchy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAX_LEVELS_IN_HIERARCHY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PaySecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PAY_SECURITY_PROFILE_ID");

                entity.Property(e => e.PersonOrAssignmentLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERSON_OR_ASSIGNMENT_LEVEL");

                entity.Property(e => e.PersonSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_SECURITY_PROFILE_ID");

                entity.Property(e => e.PositionSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_SECURITY_PROFILE_ID");

                entity.Property(e => e.PrimaryAssignmentOnly)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_ASSIGNMENT_ONLY");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PURPOSE");

                entity.Property(e => e.SecureByAor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_AOR");

                entity.Property(e => e.SecureByBusinessUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_BUSINESS_UNIT");

                entity.Property(e => e.SecureByCustomRestriction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_CUSTOM_RESTRICTION");

                entity.Property(e => e.SecureByDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_DEPARTMENT");

                entity.Property(e => e.SecureByGlobalNameRange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_GLOBAL_NAME_RANGE");

                entity.Property(e => e.SecureByGrade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_GRADE");

                entity.Property(e => e.SecureByJob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_JOB");

                entity.Property(e => e.SecureByLdg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_LDG");

                entity.Property(e => e.SecureByLegalEmployer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_LEGAL_EMPLOYER");

                entity.Property(e => e.SecureByLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_LOCATION");

                entity.Property(e => e.SecureByMgrHierarchy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_MGR_HIERARCHY");

                entity.Property(e => e.SecureByPayroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_PAYROLL");

                entity.Property(e => e.SecureByPersonType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_PERSON_TYPE");

                entity.Property(e => e.SecureByPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_POSITION");

                entity.Property(e => e.SecureIndvAssignment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_INDV_ASSIGNMENT");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerPersonTypesVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_PERSON_TYPES_VL", "FUSION");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefaultFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PersonTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_TYPE_ID");

                entity.Property(e => e.RowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROW_ID");

                entity.Property(e => e.SeededPersonTypeKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEEDED_PERSON_TYPE_KEY");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.SystemPersonType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_PERSON_TYPE");

                entity.Property(e => e.UserPersonType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_PERSON_TYPE");
            });

            modelBuilder.Entity<PerPositionSecurityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_POSITION_SECURITY_PROFILES", "FUSION");

                entity.Property(e => e.BuOrgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BU_ORG_SECURITY_PROFILE_ID");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DeptOrgSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPT_ORG_SECURITY_PROFILE_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnabledFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLED_FLAG");

                entity.Property(e => e.IncludeFuturePositions)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_FUTURE_POSITIONS");

                entity.Property(e => e.IncludeTopPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_TOP_POSITION");

                entity.Property(e => e.JobSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_SECURITY_PROFILE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LocSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOC_SECURITY_PROFILE_ID");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PosHierarchyTreeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_HIERARCHY_TREE_CODE");

                entity.Property(e => e.PosHierarchyTreeStructCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_HIERARCHY_TREE_STRUCT_CODE");

                entity.Property(e => e.PositionSecurityProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_SECURITY_PROFILE_ID");

                entity.Property(e => e.SecureByAor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_AOR");

                entity.Property(e => e.SecureByBusinessUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_BUSINESS_UNIT");

                entity.Property(e => e.SecureByDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_DEPARTMENT");

                entity.Property(e => e.SecureByJob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_JOB");

                entity.Property(e => e.SecureByLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_LOCATION");

                entity.Property(e => e.SecureByPositionHierarchy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_POSITION_HIERARCHY");

                entity.Property(e => e.SecureByPositionList)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_BY_POSITION_LIST");

                entity.Property(e => e.SeedDataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEED_DATA_SOURCE");

                entity.Property(e => e.Sguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGUID");

                entity.Property(e => e.TopPosSelection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOP_POS_SELECTION");

                entity.Property(e => e.TopPositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TOP_POSITION_ID");

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_ALL");
            });

            modelBuilder.Entity<PerRoleMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ROLE_MAPPINGS", "FUSION");

                entity.Property(e => e.AllRolesRequestableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALL_ROLES_REQUESTABLE_FLAG");

                entity.Property(e => e.AssignmentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_STATUS");

                entity.Property(e => e.AssignmentStatusTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ASSIGNMENT_STATUS_TYPE_ID");

                entity.Property(e => e.AssignmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNMENT_TYPE");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_UNIT_ID");

                entity.Property(e => e.ContactRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_ROLE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CurrentManagerFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURRENT_MANAGER_FLAG");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.GradeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("GRADE_ID");

                entity.Property(e => e.JobId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.LegalEmployerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LEGAL_EMPLOYER_ID");

                entity.Property(e => e.LocationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_TYPE");

                entity.Property(e => e.MappingName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAPPING_NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PartyUsageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARTY_USAGE_CODE");

                entity.Property(e => e.PositionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION_ID");

                entity.Property(e => e.ResourceRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RESOURCE_ROLE_ID");

                entity.Property(e => e.ResponsibilityType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSIBILITY_TYPE");

                entity.Property(e => e.RoleMappingId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_MAPPING_ID");

                entity.Property(e => e.RuleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RULE_TYPE");

                entity.Property(e => e.SystemPersonType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_PERSON_TYPE");

                entity.Property(e => e.UserPersonTypeId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_PERSON_TYPE_ID");
            });

            modelBuilder.Entity<PerRoleMappingRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ROLE_MAPPING_ROLES", "FUSION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EnterpriseId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ENTERPRISE_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RequestableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTABLE_FLAG");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleMappingId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_MAPPING_ID");

                entity.Property(e => e.RoleMappingRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_MAPPING_ROLE_ID");

                entity.Property(e => e.SelfRequestableFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SELF_REQUESTABLE_FLAG");

                entity.Property(e => e.UseForAutoProvisioningFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USE_FOR_AUTO_PROVISIONING_FLAG");
            });

            modelBuilder.Entity<PerRolesDnVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_ROLES_DN_VL", "FUSION");

                entity.Property(e => e.AbstractRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ABSTRACT_ROLE");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DataRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATA_ROLE");

                entity.Property(e => e.DelegationAllowed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELEGATION_ALLOWED");

                entity.Property(e => e.Description)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DutyRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DUTY_ROLE");

                entity.Property(e => e.ExternalId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("EXTERNAL_ID");

                entity.Property(e => e.ExternalRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_ROLE");

                entity.Property(e => e.JobRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ROLE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MultitenancyCommonName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MULTITENANCY_COMMON_NAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RoleCommonName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_COMMON_NAME");

                entity.Property(e => e.RoleDistinguishedName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_DISTINGUISHED_NAME");

                entity.Property(e => e.RoleGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_GUID");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");
            });

            modelBuilder.Entity<PerUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_USERS", "FUSION");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.CredentialsEmailSent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREDENTIALS_EMAIL_SENT");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_ID");

                entity.Property(e => e.HrTerminated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HR_TERMINATED");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MultitenancyUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MULTITENANCY_USERNAME");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.PartyId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARTY_ID");

                entity.Property(e => e.PersonId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PERSON_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Suspended)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUSPENDED");

                entity.Property(e => e.UserDataChecksum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_DATA_CHECKSUM");

                entity.Property(e => e.UserDistinguishedName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("USER_DISTINGUISHED_NAME");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GUID");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<PerUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PER_USER_ROLES", "FUSION");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.BusinessGroupId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BUSINESS_GROUP_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.MethodCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("METHOD_CODE");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.RoleGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_GUID");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.TerminatedFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TERMINATED_FLAG");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ROLE_ID");
            });

            modelBuilder.Entity<RcsMfgParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RCS_MFG_PARAMETERS", "FUSION");

                entity.Property(e => e.AllowDirectPurchWo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_DIRECT_PURCH_WO");

                entity.Property(e => e.AllowNegIssWoSnFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_NEG_ISS_WO_SN_FLAG");

                entity.Property(e => e.AutoAsscSerNumWo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_ASSC_SER_NUM_WO");

                entity.Property(e => e.BackflushLotSelection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BACKFLUSH_LOT_SELECTION");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefCompltnLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_COMPLTN_LOCATOR");

                entity.Property(e => e.DefCompltnSubinv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_COMPLTN_SUBINV");

                entity.Property(e => e.DefLabelTmplt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_LABEL_TMPLT");

                entity.Property(e => e.DefMntSchedMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_MNT_SCHED_METHOD");

                entity.Property(e => e.DefOvercompltnTol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_OVERCOMPLTN_TOL");

                entity.Property(e => e.DefSupplyLocator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_SUPPLY_LOCATOR");

                entity.Property(e => e.DefSupplySubinv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_SUPPLY_SUBINV");

                entity.Property(e => e.DefTransMode)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEF_TRANS_MODE");

                entity.Property(e => e.DefTransQty)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEF_TRANS_QTY");

                entity.Property(e => e.DefWoTravelerTmplt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_WO_TRAVELER_TMPLT");

                entity.Property(e => e.DefWorkMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEF_WORK_METHOD");

                entity.Property(e => e.EnableIotFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_IOT_FLAG");

                entity.Property(e => e.EnableProcessFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENABLE_PROCESS_FLAG");

                entity.Property(e => e.ForecastHorizon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FORECAST_HORIZON");

                entity.Property(e => e.GenWoHorizon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GEN_WO_HORIZON");

                entity.Property(e => e.IncCompYieldFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INC_COMP_YIELD_FLAG");

                entity.Property(e => e.IncludePullCompFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INCLUDE_PULL_COMP_FLAG");

                entity.Property(e => e.IssuePushCompFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISSUE_PUSH_COMP_FLAG");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE_DATE");

                entity.Property(e => e.LastUpdateLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.ManualIssueAssyWoFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANUAL_ISSUE_ASSY_WO_FLAG");

                entity.Property(e => e.MfgCalendar)
                    .HasColumnType("FLOAT")
                    .HasColumnName("MFG_CALENDAR");

                entity.Property(e => e.MtlReportingLvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MTL_REPORTING_LVL");

                entity.Property(e => e.ObjectVersionNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_VERSION_NUMBER");

                entity.Property(e => e.OprnSeqIncrement)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OPRN_SEQ_INCREMENT");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.PhntmOprnInherit)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PHNTM_OPRN_INHERIT");

                entity.Property(e => e.PickSlipGroupingRule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PICK_SLIP_GROUPING_RULE");

                entity.Property(e => e.PrintLabelExternally)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_LABEL_EXTERNALLY");

                entity.Property(e => e.PrintPickSlipsFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_PICK_SLIPS_FLAG");

                entity.Property(e => e.PurchaseReqCreateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PURCHASE_REQ_CREATE_TIME");

                entity.Property(e => e.QtyChngBackflush)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QTY_CHNG_BACKFLUSH");

                entity.Property(e => e.StartingOprnSeq)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STARTING_OPRN_SEQ");

                entity.Property(e => e.StartstopCaptureLvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STARTSTOP_CAPTURE_LVL");

                entity.Property(e => e.WoDocSeqCatCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WO_DOC_SEQ_CAT_CODE");

                entity.Property(e => e.WoDocSeqId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WO_DOC_SEQ_ID");

                entity.Property(e => e.WoStartingNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("WO_STARTING_NUMBER");

                entity.Property(e => e.WorkOrderPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WORK_ORDER_PREFIX");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
