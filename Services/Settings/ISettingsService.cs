using CommunityToolkit.Mvvm.ComponentModel;

namespace esquire.Services.Settings;

public interface ISettingsService
{
    public Options Settings { get; set; }
}

public partial class Options : ObservableObject
{
    [ObservableProperty] private DatabaseOptions _database;
    [ObservableProperty] private LoggingOptions _logging;
    
    public partial class DatabaseOptions : ObservableObject
    {
        [ObservableProperty] private ProviderType _provider ;
        [ObservableProperty] private string _userId ;
        [ObservableProperty] private string _password ;
        [ObservableProperty] private string _dataSource ;
        
        public enum ProviderType
        {
            Oracle
        }
    }

    public partial class LoggingOptions : ObservableObject
    {
        [ObservableProperty] private LogLevelOptions _logLevel;

        public partial class LogLevelOptions : ObservableObject
        {
            [ObservableProperty] private string _default;
            [ObservableProperty] private string _system;
            [ObservableProperty] private string _microsoft;
        }
    }
}
