using System.Linq;

namespace test.Models.Interfaces
{
    public interface IRepository
    {
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class, IEntity;
        TEntity GetById<TEntity>(long id) where TEntity : class, IEntity;
        bool Delete<TEntity>(long entityId) where TEntity : class, IEntity;
        TEntity Save<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void AddNew<T>(T entity) where T : class, IEntity;
        void Save();
    }
}