using System.Collections;
using System.Collections.Generic;
using esquire.Services.Settings;

namespace esquire.Services;

public abstract class ExportServiceBase : IExportService
{
    private ISettingsService _settingsService;

    public ExportServiceBase(ISettingsService settingsService) => _settingsService = settingsService;

    public abstract void Export<T>(IEnumerable<T> data, string fileName);
}