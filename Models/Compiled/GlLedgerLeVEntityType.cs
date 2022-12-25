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
    internal partial class GlLedgerLeVEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.GlLedgerLeV",
                typeof(GlLedgerLeV),
                baseEntityType);

            var accountedPeriodType = runtimeEntityType.AddProperty(
                "AccountedPeriodType",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("AccountedPeriodType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<AccountedPeriodType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            accountedPeriodType.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            accountedPeriodType.AddAnnotation("Relational:ColumnName", "ACCOUNTED_PERIOD_TYPE");

            var acctgEnvironmentCode = runtimeEntityType.AddProperty(
                "AcctgEnvironmentCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("AcctgEnvironmentCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<AcctgEnvironmentCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            acctgEnvironmentCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            acctgEnvironmentCode.AddAnnotation("Relational:ColumnName", "ACCTG_ENVIRONMENT_CODE");

            var balSegColumnName = runtimeEntityType.AddProperty(
                "BalSegColumnName",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("BalSegColumnName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<BalSegColumnName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            balSegColumnName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            balSegColumnName.AddAnnotation("Relational:ColumnName", "BAL_SEG_COLUMN_NAME");

            var balSegValueOptionCode = runtimeEntityType.AddProperty(
                "BalSegValueOptionCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("BalSegValueOptionCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<BalSegValueOptionCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            balSegValueOptionCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            balSegValueOptionCode.AddAnnotation("Relational:ColumnName", "BAL_SEG_VALUE_OPTION_CODE");

            var balSegValueSetId = runtimeEntityType.AddProperty(
                "BalSegValueSetId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("BalSegValueSetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<BalSegValueSetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            balSegValueSetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            balSegValueSetId.AddAnnotation("Relational:ColumnName", "BAL_SEG_VALUE_SET_ID");
            balSegValueSetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var chartOfAccountsId = runtimeEntityType.AddProperty(
                "ChartOfAccountsId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("ChartOfAccountsId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<ChartOfAccountsId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            chartOfAccountsId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            chartOfAccountsId.AddAnnotation("Relational:ColumnName", "CHART_OF_ACCOUNTS_ID");
            chartOfAccountsId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var configurationId = runtimeEntityType.AddProperty(
                "ConfigurationId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("ConfigurationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<ConfigurationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            configurationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            configurationId.AddAnnotation("Relational:ColumnName", "CONFIGURATION_ID");
            configurationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var currencyCode = runtimeEntityType.AddProperty(
                "CurrencyCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("CurrencyCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<CurrencyCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            currencyCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            currencyCode.AddAnnotation("Relational:ColumnName", "CURRENCY_CODE");

            var ledgerCategoryCode = runtimeEntityType.AddProperty(
                "LedgerCategoryCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LedgerCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LedgerCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            ledgerCategoryCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            ledgerCategoryCode.AddAnnotation("Relational:ColumnName", "LEDGER_CATEGORY_CODE");

            var ledgerId = runtimeEntityType.AddProperty(
                "LedgerId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LedgerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LedgerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ledgerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            ledgerId.AddAnnotation("Relational:ColumnName", "LEDGER_ID");
            ledgerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var ledgerName = runtimeEntityType.AddProperty(
                "LedgerName",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LedgerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LedgerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            ledgerName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            ledgerName.AddAnnotation("Relational:ColumnName", "LEDGER_NAME");

            var ledgerShortName = runtimeEntityType.AddProperty(
                "LedgerShortName",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LedgerShortName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LedgerShortName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ledgerShortName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            ledgerShortName.AddAnnotation("Relational:ColumnName", "LEDGER_SHORT_NAME");
            ledgerShortName.AddAnnotation("Relational:ColumnType", "FLOAT");

            var legalEntityId = runtimeEntityType.AddProperty(
                "LegalEntityId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LegalEntityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LegalEntityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            legalEntityId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            legalEntityId.AddAnnotation("Relational:ColumnName", "LEGAL_ENTITY_ID");
            legalEntityId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var legalEntityName = runtimeEntityType.AddProperty(
                "LegalEntityName",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LegalEntityName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LegalEntityName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            legalEntityName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            legalEntityName.AddAnnotation("Relational:ColumnName", "LEGAL_ENTITY_NAME");

            var locationCode = runtimeEntityType.AddProperty(
                "LocationCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LocationCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LocationCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            locationCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locationCode.AddAnnotation("Relational:ColumnName", "LOCATION_CODE");

            var locationDescription = runtimeEntityType.AddProperty(
                "LocationDescription",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LocationDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LocationDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            locationDescription.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locationDescription.AddAnnotation("Relational:ColumnName", "LOCATION_DESCRIPTION");

            var locationId = runtimeEntityType.AddProperty(
                "LocationId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("LocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<LocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            locationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locationId.AddAnnotation("Relational:ColumnName", "LOCATION_ID");
            locationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var periodSetName = runtimeEntityType.AddProperty(
                "PeriodSetName",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("PeriodSetName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<PeriodSetName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            periodSetName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            periodSetName.AddAnnotation("Relational:ColumnName", "PERIOD_SET_NAME");

            var primaryLedgerId = runtimeEntityType.AddProperty(
                "PrimaryLedgerId",
                typeof(decimal?),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("PrimaryLedgerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<PrimaryLedgerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            primaryLedgerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            primaryLedgerId.AddAnnotation("Relational:ColumnName", "PRIMARY_LEDGER_ID");
            primaryLedgerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var relationshipEnabledFlag = runtimeEntityType.AddProperty(
                "RelationshipEnabledFlag",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("RelationshipEnabledFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<RelationshipEnabledFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            relationshipEnabledFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            relationshipEnabledFlag.AddAnnotation("Relational:ColumnName", "RELATIONSHIP_ENABLED_FLAG");

            var slaAccountingMethodCode = runtimeEntityType.AddProperty(
                "SlaAccountingMethodCode",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("SlaAccountingMethodCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<SlaAccountingMethodCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            slaAccountingMethodCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            slaAccountingMethodCode.AddAnnotation("Relational:ColumnName", "SLA_ACCOUNTING_METHOD_CODE");

            var slaAccountingMethodType = runtimeEntityType.AddProperty(
                "SlaAccountingMethodType",
                typeof(string),
                propertyInfo: typeof(GlLedgerLeV).GetProperty("SlaAccountingMethodType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlLedgerLeV).GetField("<SlaAccountingMethodType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            slaAccountingMethodType.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            slaAccountingMethodType.AddAnnotation("Relational:ColumnName", "SLA_ACCOUNTING_METHOD_TYPE");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "GL_LEDGER_LE_V");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
