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
    internal partial class AseRoleTypeVlEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.AseRoleTypeVl",
                typeof(AseRoleTypeVl),
                baseEntityType);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var language = runtimeEntityType.AddProperty(
                "Language",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("Language", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<Language>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            language.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            language.AddAnnotation("Relational:ColumnName", "LANGUAGE");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var roleTypeCode = runtimeEntityType.AddProperty(
                "RoleTypeCode",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("RoleTypeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<RoleTypeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            roleTypeCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleTypeCode.AddAnnotation("Relational:ColumnName", "ROLE_TYPE_CODE");

            var roleTypeId = runtimeEntityType.AddProperty(
                "RoleTypeId",
                typeof(decimal?),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("RoleTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<RoleTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            roleTypeId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleTypeId.AddAnnotation("Relational:ColumnName", "ROLE_TYPE_ID");
            roleTypeId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var roleTypeName = runtimeEntityType.AddProperty(
                "RoleTypeName",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("RoleTypeName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<RoleTypeName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            roleTypeName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleTypeName.AddAnnotation("Relational:ColumnName", "ROLE_TYPE_NAME");

            var sourceLang = runtimeEntityType.AddProperty(
                "SourceLang",
                typeof(string),
                propertyInfo: typeof(AseRoleTypeVl).GetProperty("SourceLang", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AseRoleTypeVl).GetField("<SourceLang>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            sourceLang.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            sourceLang.AddAnnotation("Relational:ColumnName", "SOURCE_LANG");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ASE_ROLE_TYPE_VL");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}