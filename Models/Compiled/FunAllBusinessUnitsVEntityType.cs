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
    internal partial class FunAllBusinessUnitsVEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.FunAllBusinessUnitsV",
                typeof(FunAllBusinessUnitsV),
                baseEntityType);

            var buId = runtimeEntityType.AddProperty(
                "BuId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("BuId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<BuId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            buId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            buId.AddAnnotation("Relational:ColumnName", "BU_ID");
            buId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var buName = runtimeEntityType.AddProperty(
                "BuName",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("BuName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<BuName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            buName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            buName.AddAnnotation("Relational:ColumnName", "BU_NAME");

            var businessGroupId = runtimeEntityType.AddProperty(
                "BusinessGroupId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("BusinessGroupId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<BusinessGroupId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            businessGroupId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            businessGroupId.AddAnnotation("Relational:ColumnName", "BUSINESS_GROUP_ID");
            businessGroupId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var dateFrom = runtimeEntityType.AddProperty(
                "DateFrom",
                typeof(DateTime?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("DateFrom", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<DateFrom>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dateFrom.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dateFrom.AddAnnotation("Relational:ColumnName", "DATE_FROM");
            dateFrom.AddAnnotation("Relational:ColumnType", "DATE");

            var dateTo = runtimeEntityType.AddProperty(
                "DateTo",
                typeof(DateTime?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("DateTo", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<DateTo>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dateTo.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dateTo.AddAnnotation("Relational:ColumnName", "DATE_TO");
            dateTo.AddAnnotation("Relational:ColumnType", "DATE");

            var defaultCurrencyCode = runtimeEntityType.AddProperty(
                "DefaultCurrencyCode",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("DefaultCurrencyCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<DefaultCurrencyCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            defaultCurrencyCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            defaultCurrencyCode.AddAnnotation("Relational:ColumnName", "DEFAULT_CURRENCY_CODE");

            var defaultSetId = runtimeEntityType.AddProperty(
                "DefaultSetId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("DefaultSetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<DefaultSetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            defaultSetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            defaultSetId.AddAnnotation("Relational:ColumnName", "DEFAULT_SET_ID");
            defaultSetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var enabledForHrFlag = runtimeEntityType.AddProperty(
                "EnabledForHrFlag",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("EnabledForHrFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<EnabledForHrFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            enabledForHrFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enabledForHrFlag.AddAnnotation("Relational:ColumnName", "ENABLED_FOR_HR_FLAG");

            var finBusinessUnitId = runtimeEntityType.AddProperty(
                "FinBusinessUnitId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("FinBusinessUnitId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<FinBusinessUnitId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            finBusinessUnitId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            finBusinessUnitId.AddAnnotation("Relational:ColumnName", "FIN_BUSINESS_UNIT_ID");
            finBusinessUnitId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var legalEntityId = runtimeEntityType.AddProperty(
                "LegalEntityId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("LegalEntityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<LegalEntityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            legalEntityId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            legalEntityId.AddAnnotation("Relational:ColumnName", "LEGAL_ENTITY_ID");
            legalEntityId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var locationId = runtimeEntityType.AddProperty(
                "LocationId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("LocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<LocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            locationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locationId.AddAnnotation("Relational:ColumnName", "LOCATION_ID");
            locationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var managerId = runtimeEntityType.AddProperty(
                "ManagerId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("ManagerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<ManagerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            managerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            managerId.AddAnnotation("Relational:ColumnName", "MANAGER_ID");
            managerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var primaryLedgerId = runtimeEntityType.AddProperty(
                "PrimaryLedgerId",
                typeof(decimal?),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("PrimaryLedgerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<PrimaryLedgerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            primaryLedgerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            primaryLedgerId.AddAnnotation("Relational:ColumnName", "PRIMARY_LEDGER_ID");
            primaryLedgerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var profitCenterFlag = runtimeEntityType.AddProperty(
                "ProfitCenterFlag",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("ProfitCenterFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<ProfitCenterFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            profitCenterFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            profitCenterFlag.AddAnnotation("Relational:ColumnName", "PROFIT_CENTER_FLAG");

            var shortCode = runtimeEntityType.AddProperty(
                "ShortCode",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("ShortCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<ShortCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            shortCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            shortCode.AddAnnotation("Relational:ColumnName", "SHORT_CODE");

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(string),
                propertyInfo: typeof(FunAllBusinessUnitsV).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunAllBusinessUnitsV).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            status.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            status.AddAnnotation("Relational:ColumnName", "STATUS");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "FUN_ALL_BUSINESS_UNITS_V");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
