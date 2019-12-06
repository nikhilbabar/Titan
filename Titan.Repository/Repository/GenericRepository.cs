using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Titan.Data.Relational;

namespace Titan.Repository
{ 
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _set;

        public GenericRepository(DbSet<T> set)
        {
            _set = set;
        }

        public DbSet<T> Set => _set;

        public IQueryable<T> Get()
        {
            return _set;
        }

        public T Get<TKey>(TKey id)
        {
            return _set.Find(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _set.Where(predicate).AsEnumerable<T>();
        }

        public void Insert(T entity)
        {
            _set.Add(entity);

        }

        public void Update(T entity)
        {
            _set.Update(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }
    }
    
}
