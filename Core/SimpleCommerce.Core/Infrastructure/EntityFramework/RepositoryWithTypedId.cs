using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleCommerce.Infrastructure.Domain.IRepositories;
using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Infrastructure.EntityFramework
{
    public class RepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> where T : class, IEntityWithTypedId<TId>
    {
        public RepositoryWithTypedId(SimpleDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        protected DbContext Context { get; }

        protected DbSet<T> DbSet { get; }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChange()
        {
            Context.SaveChanges();
        }

        public IQueryable<T> Query()
        {
            return DbSet;
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}