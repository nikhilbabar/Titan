using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Titan.Repository.Interface
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> Get();
        Task<IEnumerable<T>> GetAsync();
        T Get<TKey>(TKey id);
        Task<T> GetAsync<TKey>(TKey id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
        T Insert(T entity);
        Task<T> InsertAsync(T entity);
        IList<T> InsertRange(IList<T> entities);
        Task<IList<T>> InsertRangeAsync(IList<T> entities);
        T Update(T entity);
        IList<T> UpdateRange(IList<T> entities);
        void Delete(T entity);
        void DeleteRange(IList<T> entities);
    }
}
