using System;
using System.Data.Entity;
using System.Linq;
using test.Data.Context;
using test.Models.Interfaces;

namespace test.Data
{
    public class Repository : IRepository
    {
        private readonly Model _context;

        public Repository(Model context)
        {
            _context = context;
        }

        public bool Delete<T>(long entityId) where T : class
        {
            DbSet<T> set = _context.Set<T>();
            T entity = set.Find(entityId);
            if (entity != null)
            {
                set.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void AddNew<T>(T entity) where T : class
        {
            DbSet<T> set = _context.Set<T>();
            set.Add(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById<T>(long id) where T : class
        {
            return _context.Set<T>().Find(id);
        }

        public T Save<T>(T entity) where T : class
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            //вставить проверку на новую строку
            _context.SaveChanges();
            return entity;
        }
    }
}