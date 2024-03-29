﻿// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
using Oracle.EntityFrameworkCore.Metadata;
using esquire.Models.Fusion;

#pragma warning disable 219, 612, 618
#nullable enable

namespace esquire.Models.Compiled
{
    internal partial class HrAllOrganizationUnitsFEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.HrAllOrganizationUnitsF",
                typeof(HrAllOrganizationUnitsF),
                baseEntityType);

            var actionOccurrenceId = runtimeEntityType.AddProperty(
                "ActionOccurrenceId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("ActionOccurrenceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<ActionOccurrenceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            actionOccurrenceId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            actionOccurrenceId.AddAnnotation("Relational:ColumnName", "ACTION_OCCURRENCE_ID");
            actionOccurrenceId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var businessGroupId = runtimeEntityType.AddProperty(
                "BusinessGroupId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("BusinessGroupId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<BusinessGroupId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            businessGroupId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            businessGroupId.AddAnnotation("Relational:ColumnName", "BUSINESS_GROUP_ID");
            businessGroupId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var costAllocationKeyflexId = runtimeEntityType.AddProperty(
                "CostAllocationKeyflexId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("CostAllocationKeyflexId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<CostAllocationKeyflexId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            costAllocationKeyflexId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            costAllocationKeyflexId.AddAnnotation("Relational:ColumnName", "COST_ALLOCATION_KEYFLEX_ID");
            costAllocationKeyflexId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var effectiveEndDate = runtimeEntityType.AddProperty(
                "EffectiveEndDate",
                typeof(DateTime?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("EffectiveEndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<EffectiveEndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveEndDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveEndDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_END_DATE");
            effectiveEndDate.AddAnnotation("Relational:ColumnType", "DATE");

            var effectiveStartDate = runtimeEntityType.AddProperty(
                "EffectiveStartDate",
                typeof(DateTime?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("EffectiveStartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<EffectiveStartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveStartDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveStartDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_START_DATE");
            effectiveStartDate.AddAnnotation("Relational:ColumnType", "DATE");

            var establishmentId = runtimeEntityType.AddProperty(
                "EstablishmentId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("EstablishmentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<EstablishmentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            establishmentId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            establishmentId.AddAnnotation("Relational:ColumnName", "ESTABLISHMENT_ID");
            establishmentId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var internalAddressLine = runtimeEntityType.AddProperty(
                "InternalAddressLine",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("InternalAddressLine", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<InternalAddressLine>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            internalAddressLine.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            internalAddressLine.AddAnnotation("Relational:ColumnName", "INTERNAL_ADDRESS_LINE");

            var internalExternalFlag = runtimeEntityType.AddProperty(
                "InternalExternalFlag",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("InternalExternalFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<InternalExternalFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            internalExternalFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            internalExternalFlag.AddAnnotation("Relational:ColumnName", "INTERNAL_EXTERNAL_FLAG");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var legalEntityId = runtimeEntityType.AddProperty(
                "LegalEntityId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("LegalEntityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<LegalEntityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            legalEntityId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            legalEntityId.AddAnnotation("Relational:ColumnName", "LEGAL_ENTITY_ID");
            legalEntityId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var locationId = runtimeEntityType.AddProperty(
                "LocationId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("LocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<LocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            locationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locationId.AddAnnotation("Relational:ColumnName", "LOCATION_ID");
            locationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var moduleId = runtimeEntityType.AddProperty(
                "ModuleId",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("ModuleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<ModuleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            moduleId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            moduleId.AddAnnotation("Relational:ColumnName", "MODULE_ID");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var organizationCode = runtimeEntityType.AddProperty(
                "OrganizationCode",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("OrganizationCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<OrganizationCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            organizationCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            organizationCode.AddAnnotation("Relational:ColumnName", "ORGANIZATION_CODE");

            var organizationId = runtimeEntityType.AddProperty(
                "OrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("OrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<OrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            organizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            organizationId.AddAnnotation("Relational:ColumnName", "ORGANIZATION_ID");
            organizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var type = runtimeEntityType.AddProperty(
                "Type",
                typeof(string),
                propertyInfo: typeof(HrAllOrganizationUnitsF).GetProperty("Type", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(HrAllOrganizationUnitsF).GetField("<Type>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            type.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            type.AddAnnotation("Relational:ColumnName", "TYPE");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "HR_ALL_ORGANIZATION_UNITS_F");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
