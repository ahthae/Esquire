using System.Collections.Generic;
using System.Data.Common;
using esquire.Models;
using esquire.Services.Settings;
using Oracle.ManagedDataAccess.Client;

namespace esquire.Services
{
    public class OralceService : DatabaseService
    {
        public OralceService(ISettingsService settings)
        {
            Factory = DbProviderFactories.GetFactory(new OracleConnection());
            DbConnectionStringBuilder connectionStringBuilder = Factory.CreateConnectionStringBuilder();
            connection = Factory.CreateConnection();

            Options options = settings.Settings;
            connectionStringBuilder.Add("User Id", settings.Settings.Database.Provider);
            connectionStringBuilder.Add("Password", "<password>");
            connectionStringBuilder.Add("Data Source", "localhost/XEPDB1");
            connection.ConnectionString = connectionStringBuilder.ToString();
        }

        public override void Query<T>(List<T> list)
        {
            DbDataReader reader = getQueryReader(SqlQueries.businessUnits);
            while (reader.Read())
            {
                var bu = new BusinessUnit(reader.IsDBNull(0) ? (double?)null : reader.GetDouble(0),
                    reader.IsDBNull(1) ? null : reader.GetString(1),
                    reader.IsDBNull(2) ? null : reader.GetDouble(2),
                    reader.IsDBNull(3) ? null : reader.GetDouble(3),
                    reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                    reader.IsDBNull(6) ? null : reader.GetDouble(6),
                    reader.IsDBNull(7) ? null : reader.GetDouble(7),
                    reader.IsDBNull(8) ? null : reader.GetDouble(8),
                    reader.IsDBNull(9) ? null : reader.GetDouble(9),
                    reader.IsDBNull(10) ? null : reader.GetString(10),
                    reader.IsDBNull(11) ? null : reader.GetString(11),
                    reader.IsDBNull(12) ? null : reader.GetDouble(12),
                    reader.IsDBNull(13) ? null : reader.GetString(13),
                    reader.IsDBNull(14) ? null : reader.GetString(14),
                    reader.IsDBNull(15) ? null : reader.GetString(15),
                    reader.IsDBNull(16) ? null : reader.GetDateTime(16),
                    reader.IsDBNull(17) ? null : reader.GetString(17),
                    reader.IsDBNull(18) ? null : reader.GetString(18),
                    reader.IsDBNull(19) ? null : reader.GetString(19));
                list.Add((T)bu);
            }
        }
        
    }
}
