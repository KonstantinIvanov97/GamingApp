using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GamingApp.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly GamingAppDbContext context;

        private readonly DbSet<TEntity> dbSet;

        public DbRepository(GamingAppDbContext dbContext)
        {
            this.context = dbContext;
            this.dbSet = this.context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public TEntity FindById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
