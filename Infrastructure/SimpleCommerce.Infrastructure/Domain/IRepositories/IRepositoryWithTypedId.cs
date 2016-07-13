using System.Linq;
using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Infrastructure.Domain.IRepositories
{
    public interface IRepositoryWithTypedId<T, in TId> 
        where T : IEntityWithTypedId<TId>
    {
        IQueryable<T> Query();

        void Add(T entity);

        void SaveChange();

        void Remove(T entity);
    }
}