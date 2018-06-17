using System.Linq;

namespace test.Models.Interfaces
{
    public interface IRepository
    {
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        TEntity GetById<TEntity>(long id) where TEntity : class;
        bool Delete<TEntity>(long entityId) where TEntity : class;
        TEntity Save<TEntity>(TEntity entity) where TEntity : class;
        void AddNew<T>(T entity) where T : class;
    }
}