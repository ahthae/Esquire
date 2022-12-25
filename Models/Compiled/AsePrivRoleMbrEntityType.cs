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
    internal partial class AsePrivRoleMbrEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.AsePrivRoleMbr",
                typeof(AsePrivRoleMbr),
                baseEntityType);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var dataSyncId = runtimeEntityType.AddProperty(
                "DataSyncId",
                typeof(decimal?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("DataSyncId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<DataSyncId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dataSyncId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dataSyncId.AddAnnotation("Relational:ColumnName", "DATA_SYNC_ID");
            dataSyncId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var effectiveEndDate = runtimeEntityType.AddProperty(
                "EffectiveEndDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("EffectiveEndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<EffectiveEndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveEndDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveEndDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_END_DATE");
            effectiveEndDate.AddAnnotation("Relational:ColumnType", "DATE");

            var effectiveStartDate = runtimeEntityType.AddProperty(
                "EffectiveStartDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("EffectiveStartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<EffectiveStartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveStartDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveStartDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_START_DATE");
            effectiveStartDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var membershipId = runtimeEntityType.AddProperty(
                "MembershipId",
                typeof(decimal?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("MembershipId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<MembershipId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            membershipId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            membershipId.AddAnnotation("Relational:ColumnName", "MEMBERSHIP_ID");
            membershipId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var privilegeId = runtimeEntityType.AddProperty(
                "PrivilegeId",
                typeof(decimal?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("PrivilegeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<PrivilegeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            privilegeId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            privilegeId.AddAnnotation("Relational:ColumnName", "PRIVILEGE_ID");
            privilegeId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var roleId = runtimeEntityType.AddProperty(
                "RoleId",
                typeof(decimal?),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("RoleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<RoleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            roleId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleId.AddAnnotation("Relational:ColumnName", "ROLE_ID");
            roleId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var staged = runtimeEntityType.AddProperty(
                "Staged",
                typeof(string),
                propertyInfo: typeof(AsePrivRoleMbr).GetProperty("Staged", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePrivRoleMbr).GetField("<Staged>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            staged.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            staged.AddAnnotation("Relational:ColumnName", "STAGED");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ASE_PRIV_ROLE_MBR");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}