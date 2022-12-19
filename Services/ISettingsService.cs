namespace esquire.Services;

public interface ISettingsService
{
    public IOptions Settings { get; set; }
    
    public interface IOptions
    {
        public enum DatabaseProvider
        {
            Oracle
        }
        public DatabaseProvider DbProvider { get; set; }
    }
}