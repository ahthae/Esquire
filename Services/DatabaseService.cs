using esquire.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using esquire.Services.Settings;

namespace esquire.Services
{
    public abstract class DatabaseService : IDatabaseService
    {
        public DbProviderFactory Factory { get; init; }
        public DbConnection connection { get; set; }
        protected DbDataAdapter adapter { get; set; }

        public abstract void Query<T>(List<T> list) where T : BusinessUnit;
        
        protected DbDataReader getQueryReader(string query)
        {
            DbCommand command = Factory.CreateCommand();
            command.Connection = connection;
            command.CommandText = query;
            return getQueryReader(command);
        }
        protected DbDataReader getQueryReader(DbCommand command)
        {
            try
            {
                connection.Open();
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return null;
        }
        
        protected struct SqlQueries
        {
            public const string businessUnits = @"SELECT
           fabuv.BU_ID                 ""Business Unit ID."",
           fabuv.BU_NAME               ""Business Unit Name"",
           fabuv.LOCATION_ID           ""Location ID."",
           fabuv.BUSINESS_GROUP_ID     ""Business Group ID."",
           fabuv.DATE_FROM             ""Date From"",
           fabuv.DATE_TO               ""Date To"",
           fabuv.MANAGER_ID            ""Manager ID."",
           fabuv.LEGAL_ENTITY_ID       ""Legal Entity ID."",
           fabuv.PRIMARY_LEDGER_ID     ""Primary Ledger ID."",
           fabuv.DEFAULT_SET_ID        ""Default Set ID."",
           fabuv.SHORT_CODE            ""Short Code"",
           fabuv.ENABLED_FOR_HR_FLAG   ""Enabled for HR?"",
           fabuv.FIN_BUSINESS_UNIT_ID  ""Financial Business Unit ID."",
           fabuv.DEFAULT_CURRENCY_CODE ""Default Currency Code"",
           fabuv.PROFIT_CENTER_FLAG    ""Profit Center?"",
           fabuv.STATUS                ""Status"",
           fabuv.CREATION_DATE         ""Creation Date"",
           fabuv.LAST_UPDATED_BY       ""Last Updated By"",
           fabuv.LAST_UPDATE_DATE      ""Last Update Date"",
           fabuv.LAST_UPDATE_LOGIN     ""Last Update Login""
    FROM FUSION.FUN_ALL_BUSINESS_UNITS_V fabuv
    WHERE NVL(to_date(fabuv.DATE_TO, 'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate
    ORDER BY ""Business Unit Name""";

            public const string businessUnitOrganizations = @"SELECT DISTINCT hou.ORGANIZATION_ID     ""Organization ID."",
                            hou.NAME                ""Org. Name (Business Unit Name)"",
                            haouf.business_group_id ""Business Group ID."",
                            hou.DATE_TO             ""Org. To Date""
            FROM FUSION.HR_ORG_UNIT_CLASSIFICATIONS_F HOUCF,
                 FUSION.HR_ALL_ORGANIZATION_UNITS_F   HAOUF,
                 FUSION.HR_ORGANIZATION_UNITS         hou
            WHERE hou.ORGANIZATION_ID       = haouf.ORGANIZATION_ID
            AND   haouf.ORGANIZATION_ID     = houcf.ORGANIZATION_ID
            AND   houcf.CLASSIFICATION_CODE = 'FUN_BUSINESS_UNIT'
            AND   NVL(to_date(HOUCF.effective_end_date, 'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate
            AND   NVL(to_date(HAOUF.effective_end_date, 'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate
            AND   NVL(to_date(hou.DATE_TO,              'dd-MON-RR HH:MI:SS AM'), sysdate) >= sysdate
            ORDER BY ""Org. Name (Business Unit Name)""";
        }
    }
   
}