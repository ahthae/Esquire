using System;
using System.Collections;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using esquire.Services.Settings;

namespace esquire.Services.Export;

public class CsvExportService : ExportServiceBase
{
    private CsvConfiguration _configuration;
    
    public CsvExportService(ISettingsService settingsService) : base(settingsService)
    {
        _configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            NewLine = Environment.NewLine
        };
    }

    public override void Export(IEnumerable data, string exportPath)
    {
        using (StreamWriter writer = new StreamWriter(exportPath))
        using (CsvWriter csv = new CsvWriter(writer, _configuration))
        {
            csv.WriteRecordsAsync(data);
        }
    }
}