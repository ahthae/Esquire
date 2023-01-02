using System.Collections.Generic;
using System.Threading.Tasks;
using esquire.Data;

namespace esquire.Queries;

public interface IQuery<T> where T : IDto
{
    public Task<IEnumerable<T>> GetAsync();
}