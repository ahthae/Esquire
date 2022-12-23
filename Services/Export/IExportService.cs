using System.Collections;

namespace esquire.Services.Export;

public interface IExportService
{
    public void Export(IEnumerable data, string exportFile);
}