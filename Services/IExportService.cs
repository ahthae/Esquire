using System.Collections;

namespace esquire.Services;

public interface IExportService
{
    public void Export(IEnumerable data, string exportFile);
}