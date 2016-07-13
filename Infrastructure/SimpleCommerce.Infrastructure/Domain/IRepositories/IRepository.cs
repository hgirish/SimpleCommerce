using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Infrastructure.Domain.IRepositories
{
    public interface IRepository<T> 
        : IRepositoryWithTypedId<T, long> 
        where T : IEntityWithTypedId<long>
    {
    }
}