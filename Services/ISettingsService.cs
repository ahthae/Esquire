using System.Data.Common;
using Microsoft.Extensions.Configuration;

namespace esquire.Services;

public interface ISettingsService
{
    public AppSettings Settings { get; set; }
    
    public class AppSettings
    {
        public enum DatabaseProvider
        {
            Oracle
        }
        public DatabaseProvider Database { get; set; }
    }
}