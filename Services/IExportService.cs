using System.Collections;
using System.Collections.Generic;

namespace esquire.Services;

public interface IExportService
{
    public void Export<T>(IEnumerable<T> data, string exportFile);
}