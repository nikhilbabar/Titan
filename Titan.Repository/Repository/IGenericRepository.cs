using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Titan.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        IQueryable<T> Get();
        T Get<TKey>(TKey id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
