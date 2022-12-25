using esquire.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using esquire.Services;
using esquire.Services.Settings;
using Oracle.ManagedDataAccess.Client;

namespace esquire.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ISettingsService _settings;

        public DatabaseService(ISettingsService settings)
        {
            _settings = settings;
            Factory = DbProviderFactories.GetFactory(GetProvider(settings.Settings.Database.Provider));
        }

        private DbProviderFactory? Factory { get; init; }

        public DbConnection? GetConnection()
        {
            DbConnection? connection = Factory.CreateConnection();
            DbConnectionStringBuilder? connectionStringBuilder = Factory.CreateConnectionStringBuilder();
            connectionStringBuilder.Add("User Id", _settings.Settings.Database.UserId);
            connectionStringBuilder.Add("Password", _settings.Settings.Database.Password);
            connectionStringBuilder.Add("Data Source", _settings.Settings.Database.DataSource);
            connection.ConnectionString = connectionStringBuilder.ToString();
            return connection;
        }

        private static DbConnection GetProvider(Settings.Options.DatabaseOptions.ProviderType settingsProviderType) =>
            settingsProviderType switch
            {
                Settings.Options.DatabaseOptions.ProviderType.Oracle => new OracleConnection()
            };
    }
}