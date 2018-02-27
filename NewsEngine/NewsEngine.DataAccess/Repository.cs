using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NewsEngine.Contracts;
using System.Data.Entity;

namespace NewsEngine.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Private properties

        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        #endregion

        #region Constructors

        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        #endregion

        #region Public properties

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return _dbSet.Any(where);
        }

        public void Delete(Guid? id)
        {
            var entityToDelete = _dbSet.Find(id);

            Delete(entityToDelete);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where, Expression<Func<T, object>> include)
        {
            return _dbSet.Where(where).Include(include).ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where, Expression<Func<T, object>> include1, Expression<Func<T, object>> include2)
        {
            return _dbSet.Where(where).Include(include1).Include(include2).ToList();
        }

        public T GetById(Guid? id)
        {
            if (id != null)
            {
                return _dbSet.Find(id);
            }
            return null;
        }      

        public int GetCount(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).Count();
        }

        public T GetElement(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        #endregion

        #region Private properties

        private void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }

            _dbSet.Remove(entityToDelete);
        }

        #endregion
    }
}
