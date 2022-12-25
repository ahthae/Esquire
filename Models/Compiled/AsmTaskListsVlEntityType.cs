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
    internal partial class AsmTaskListsVlEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.AsmTaskListsVl",
                typeof(AsmTaskListsVl),
                baseEntityType);

            var activityTypeCode = runtimeEntityType.AddProperty(
                "ActivityTypeCode",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ActivityTypeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ActivityTypeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            activityTypeCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            activityTypeCode.AddAnnotation("Relational:ColumnName", "ACTIVITY_TYPE_CODE");

            var applicationId = runtimeEntityType.AddProperty(
                "ApplicationId",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ApplicationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ApplicationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            applicationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            applicationId.AddAnnotation("Relational:ColumnName", "APPLICATION_ID");
            applicationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var availableReleaseVersion = runtimeEntityType.AddProperty(
                "AvailableReleaseVersion",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("AvailableReleaseVersion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<AvailableReleaseVersion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            availableReleaseVersion.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            availableReleaseVersion.AddAnnotation("Relational:ColumnName", "AVAILABLE_RELEASE_VERSION");

            var copyEnabledFlag = runtimeEntityType.AddProperty(
                "CopyEnabledFlag",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("CopyEnabledFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<CopyEnabledFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            copyEnabledFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            copyEnabledFlag.AddAnnotation("Relational:ColumnName", "COPY_ENABLED_FLAG");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var deepCopyFlag = runtimeEntityType.AddProperty(
                "DeepCopyFlag",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("DeepCopyFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<DeepCopyFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            deepCopyFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            deepCopyFlag.AddAnnotation("Relational:ColumnName", "DEEP_COPY_FLAG");

            var deliveryReleaseVersion = runtimeEntityType.AddProperty(
                "DeliveryReleaseVersion",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("DeliveryReleaseVersion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<DeliveryReleaseVersion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            deliveryReleaseVersion.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            deliveryReleaseVersion.AddAnnotation("Relational:ColumnName", "DELIVERY_RELEASE_VERSION");

            var enabledFlag = runtimeEntityType.AddProperty(
                "EnabledFlag",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("EnabledFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<EnabledFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            enabledFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enabledFlag.AddAnnotation("Relational:ColumnName", "ENABLED_FLAG");

            var enterpriseId = runtimeEntityType.AddProperty(
                "EnterpriseId",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("EnterpriseId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<EnterpriseId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            enterpriseId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enterpriseId.AddAnnotation("Relational:ColumnName", "ENTERPRISE_ID");
            enterpriseId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var expirationReleaseVersion = runtimeEntityType.AddProperty(
                "ExpirationReleaseVersion",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ExpirationReleaseVersion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ExpirationReleaseVersion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            expirationReleaseVersion.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            expirationReleaseVersion.AddAnnotation("Relational:ColumnName", "EXPIRATION_RELEASE_VERSION");

            var fusionRelease = runtimeEntityType.AddProperty(
                "FusionRelease",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("FusionRelease", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<FusionRelease>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            fusionRelease.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            fusionRelease.AddAnnotation("Relational:ColumnName", "FUSION_RELEASE");

            var helpTopicId = runtimeEntityType.AddProperty(
                "HelpTopicId",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("HelpTopicId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<HelpTopicId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            helpTopicId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            helpTopicId.AddAnnotation("Relational:ColumnName", "HELP_TOPIC_ID");

            var hierarchyNumber = runtimeEntityType.AddProperty(
                "HierarchyNumber",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("HierarchyNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<HierarchyNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            hierarchyNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            hierarchyNumber.AddAnnotation("Relational:ColumnName", "HIERARCHY_NUMBER");

            var inContextFlag = runtimeEntityType.AddProperty(
                "InContextFlag",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("InContextFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<InContextFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            inContextFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            inContextFlag.AddAnnotation("Relational:ColumnName", "IN_CONTEXT_FLAG");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var moduleId = runtimeEntityType.AddProperty(
                "ModuleId",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ModuleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ModuleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            moduleId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            moduleId.AddAnnotation("Relational:ColumnName", "MODULE_ID");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var origTaskListId = runtimeEntityType.AddProperty(
                "OrigTaskListId",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("OrigTaskListId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<OrigTaskListId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            origTaskListId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            origTaskListId.AddAnnotation("Relational:ColumnName", "ORIG_TASK_LIST_ID");
            origTaskListId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var owner = runtimeEntityType.AddProperty(
                "Owner",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("Owner", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<Owner>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            owner.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            owner.AddAnnotation("Relational:ColumnName", "OWNER");

            var serviceId = runtimeEntityType.AddProperty(
                "ServiceId",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("ServiceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<ServiceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            serviceId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            serviceId.AddAnnotation("Relational:ColumnName", "SERVICE_ID");
            serviceId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var taskListDesc = runtimeEntityType.AddProperty(
                "TaskListDesc",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("TaskListDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<TaskListDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 400,
                unicode: false);
            taskListDesc.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            taskListDesc.AddAnnotation("Relational:ColumnName", "TASK_LIST_DESC");

            var taskListId = runtimeEntityType.AddProperty(
                "TaskListId",
                typeof(decimal?),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("TaskListId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<TaskListId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            taskListId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            taskListId.AddAnnotation("Relational:ColumnName", "TASK_LIST_ID");
            taskListId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var taskListName = runtimeEntityType.AddProperty(
                "TaskListName",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("TaskListName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<TaskListName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150,
                unicode: false);
            taskListName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            taskListName.AddAnnotation("Relational:ColumnName", "TASK_LIST_NAME");

            var taskListShortName = runtimeEntityType.AddProperty(
                "TaskListShortName",
                typeof(string),
                propertyInfo: typeof(AsmTaskListsVl).GetProperty("TaskListShortName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsmTaskListsVl).GetField("<TaskListShortName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150,
                unicode: false);
            taskListShortName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            taskListShortName.AddAnnotation("Relational:ColumnName", "TASK_LIST_SHORT_NAME");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ASM_TASK_LISTS_VL");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
