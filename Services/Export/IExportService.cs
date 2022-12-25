using System.Collections;
using System.Threading.Tasks;

namespace esquire.Services.Export;

public interface IExportService
{
    public Task ExportAsync(IEnumerable data, string exportFile);
}