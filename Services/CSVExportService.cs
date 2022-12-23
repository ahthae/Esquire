using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using esquire.Services.Settings;

namespace esquire.Services;

public class CSVExportService : ExportServiceBase
{
    private List<string> _output = new();
    private ISettingsService _settingsService;
    
    public CSVExportService(ISettingsService settingsService) : base(settingsService)
    {
        _settingsService = settingsService;
    }

    public override void Export<T>(IEnumerable<T> data, string fileName)
    {
        foreach (var i in data)
        {
            string row = "";
            foreach (var p in i.GetType().GetProperties())
            {
                row += $"{p.Name},";
            }
            _output.Add(row);
        }

        File.WriteAllLines(Path.Join(_settingsService.Settings.ExportDirectory, fileName), _output);
    }
}