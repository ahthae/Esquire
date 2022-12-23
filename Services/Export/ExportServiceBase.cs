using System.Collections;
using esquire.Services.Settings;

namespace esquire.Services.Export;

public abstract class ExportServiceBase : IExportService
{
    protected ISettingsService _settingsService;

    public ExportServiceBase(ISettingsService settingsService) => _settingsService = settingsService;

    public abstract void Export(IEnumerable data, string fileName);
}