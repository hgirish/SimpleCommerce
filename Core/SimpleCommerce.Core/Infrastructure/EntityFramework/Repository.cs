using SimpleCommerce.Infrastructure.Domain.IRepositories;
using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Infrastructure.EntityFramework
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
        where T : class, IEntityWithTypedId<long>
    {
        public Repository(SimpleDbContext context) : base(context)
        {
        }
    }
}