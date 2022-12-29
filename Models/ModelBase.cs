using System.Linq;

namespace esquire.Models
{
    public abstract class ModelBase
    {
        public abstract IOrderedQueryable QueryAsync();
    }
}
