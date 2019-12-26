using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Titan.Repository.Interface;
using Titan.Service.Interface;

namespace Titan.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        protected readonly IGenericRepository<TEntity> _repository;

        public BaseService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<TEntity> GetEntities()
        {
            return _repository.Get();
        }

        public virtual async Task<IEnumerable<TEntity>> GetEntitiesAsync()
        {
            return await _repository.GetAsync();
        }

        public virtual TEntity GetEntity<TKey>(TKey id)
        {
            return _repository.Get(id);
        }

        public virtual async Task<TEntity> GetEntityAsync<TKey>(TKey id)
        {
            return await _repository.GetAsync(id);
        }

        public virtual IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Get(predicate);
        }

        public virtual async Task<IEnumerable<TEntity>> GetEntitiesAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.GetAsync(predicate);
        }

        public virtual TEntity InsertEntity(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public virtual async Task<TEntity> InsertEntityAsync(TEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public virtual IList<TEntity> InsertEntities(IList<TEntity> entities)
        {
            return _repository.InsertRange(entities);
        }

        public virtual async Task<IList<TEntity>> InsertEntitiesAsync(IList<TEntity> entities)
        {
            return await _repository.InsertRangeAsync(entities);
        }

        public virtual TEntity UpdateEntity(TEntity entity)
        {
            return _repository.Update(entity);
        }

        public virtual IList<TEntity> UpdateEntities(IList<TEntity> entities)
        {
            return _repository.UpdateRange(entities);
        }

        public virtual void DeleteEntity(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public virtual void DeleteEntities(IList<TEntity> entities)
        {
            _repository.DeleteRange(entities);
        }

    }
}
