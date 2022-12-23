using System.Collections;
using System.Collections.Generic;
using System.IO;
using esquire.Services.Settings;

namespace esquire.Services;

public class CsvExportService : ExportServiceBase
{
    private ISettingsService _settingsService;
    
    public CsvExportService(ISettingsService settingsService) : base(settingsService)
    {
        _settingsService = settingsService;
    }

    public override void Export(IEnumerable data, string exportPath)
    {
        List<string> output = new();
        
        //TODO headers
        
        foreach (var i in data)
        {
            string row = "";
            foreach (var p in i.GetType().GetProperties())
            {
                row += $"{p.GetValue(i)},"; //TODO Handle comma delimiter sanitation (or just all CSV delimiting (or even ExportService delimiting helper functions)
            }
            output.Add(row);
        }

        string? directory = Path.GetDirectoryName(exportPath);
        if (directory is not null && !Directory.Exists(directory)) Directory.CreateDirectory(directory); //TODO
        File.WriteAllLinesAsync(exportPath, output);
    }
}