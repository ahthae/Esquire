using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using esquire.Models.Fusion;
using esquire.Services;
using Microsoft.Extensions.Logging;

namespace esquire.Data.Fusion
{
    public partial class BusinessUnitsContext : DbContext
    {
        public BusinessUnitsContext()
        {
        }

        public BusinessUnitsContext(DbContextOptions<BusinessUnitsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AseRoleVl> AseRoleVls { get; set; } = null!;
        public virtual DbSet<FunAllBusinessUnitsV> FunAllBusinessUnitsVs { get; set; } = null!;
        public virtual DbSet<FunUserRoleDataAsgnmnt> FunUserRoleDataAsgnmnts { get; set; } = null!;
        public virtual DbSet<HrAllOrganizationUnitsF> HrAllOrganizationUnitsFs { get; set; } = null!;
        public virtual DbSet<HrOrgUnitClassificationsF> HrOrgUnitClassificationsFs { get; set; } = null!;
        public virtual DbSet<HrOrganizationUnit> HrOrganizationUnits { get; set; } = null!;
        public virtual DbSet<PerAllAssignmentsM> PerAllAssignmentsMs { get; set; } = null!;
        public virtual DbSet<PerAllPeopleF> PerAllPeopleFs { get; set; } = null!;
        public virtual DbSet<PerUser> PerUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IDatabaseService db = Ioc.Default.GetRequiredService<IDatabaseService>();
                optionsBuilder.UseLoggerFactory(Ioc.Default.GetRequiredService<ILoggerFactory>());
                optionsBuilder.UseModel(Models.Compiled.BusinessUnitsContextModel.Instance);
                optionsBuilder.UseOracle(db.CreateConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("USING_NLS_COMP");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
