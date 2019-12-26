using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Service.Interface
{
    public interface IBaseService<T> where T : class, new()
    {
        IEnumerable<T> GetEntities();
        Task<IEnumerable<T>> GetEntitiesAsync();
        T GetEntity<TKey>(TKey id);
        Task<T> GetEntityAsync<TKey>(TKey id);
        IEnumerable<T> GetEntities(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetEntitiesAsync(Expression<Func<T, bool>> predicate);
        T InsertEntity(T entity);
        Task<T> InsertEntityAsync(T entity);
        IList<T> InsertEntities(IList<T> entities);
        Task<IList<T>> InsertEntitiesAsync(IList<T> entities);
        T UpdateEntity(T entity);
        IList<T> UpdateEntities(IList<T> entities);
        void DeleteEntity(T entity);
        void DeleteEntities(IList<T> entities);
    }
}
