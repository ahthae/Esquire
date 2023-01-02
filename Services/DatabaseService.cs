using System.Data.Common;
using esquire.Services.Settings;
using Oracle.ManagedDataAccess.Client;

namespace esquire.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ISettingsService _settingsService;

        public DatabaseService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            Factory = DbProviderFactories.GetFactory(GetProvider(_settingsService.Settings.Database.Provider));
        }

        private DbProviderFactory? Factory { get; init; }

        public string CreateConnectionString() => CreateConnectionString(_settingsService.Settings);
        public string CreateConnectionString(Options settings)
        {
            DbConnectionStringBuilder? connectionStringBuilder = Factory.CreateConnectionStringBuilder();
            connectionStringBuilder.Add("User Id", settings.Database.UserId);
            connectionStringBuilder.Add("Password", settings.Database.Password);
            connectionStringBuilder.Add("Data Source", settings.Database.DataSource);
            return connectionStringBuilder.ToString();
        }

        public DbConnection? GetConnection() => GetConnection(_settingsService.Settings);
        public DbConnection? GetConnection(Options settings)
        {
            DbConnection? connection = Factory.CreateConnection();
            connection.ConnectionString = CreateConnectionString(settings);
            return connection;
        }

        private static DbConnection GetProvider(DatabaseOptions.ProviderType settingsProviderType) =>
            settingsProviderType switch
            {
                DatabaseOptions.ProviderType.Oracle => new OracleConnection()
            };
    }
}