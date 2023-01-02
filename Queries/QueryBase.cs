using System.Collections.Generic;
using System.Threading.Tasks;
using esquire.Data;
using Microsoft.EntityFrameworkCore;

namespace esquire.Queries;

public abstract class QueryBase<T> : IQuery<T> where T : IDto 
{
    protected DbContext _context;

    protected QueryBase(DbContext context)
    {
        _context = context;
    }

    public abstract Task<IEnumerable<T>> GetAsync();
}