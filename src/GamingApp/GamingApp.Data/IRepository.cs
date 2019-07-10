using System.Linq;

namespace GamingApp.Data
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        TEntity FindById(int id);

        void SaveChanges();

        IQueryable<TEntity> All();
    }
}
