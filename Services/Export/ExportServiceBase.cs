using System.Collections;
using System.Threading.Tasks;
using esquire.Services.Settings;

namespace esquire.Services.Export;

public abstract class ExportServiceBase : IExportService
{
    protected ISettingsService _settingsService;

    public ExportServiceBase(ISettingsService settingsService) => _settingsService = settingsService;

    public abstract Task ExportAsync(IEnumerable data, string fileName);
}