using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Titan.Data.Relational;
using Titan.Repository.Interface;

namespace Titan.Repository
{ 
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly RelationalContext _context;
        private DbSet<T> _set;

        public GenericRepository(RelationalContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }
        
        public IEnumerable<T> Get()
        {
            return _set;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _set.ToListAsync();
        }
        
        public T Get<TKey>(TKey id)
        {
            return _set.Find(id);
        }

        public async Task<T> GetAsync<TKey>(TKey id)
        {
            return await _set.FindAsync(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _set.Where(predicate).AsEnumerable();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _set.Where(predicate).ToListAsync();
        }
        
        public T Insert(T entity)
        {
            _set.Add(entity);
            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _set.AddAsync(entity);
            return entity;
        }

        public IList<T> InsertRange(IList<T> entities)
        {
            _set.AddRange(entities);
            return entities;
        }

        public async Task<IList<T>> InsertRangeAsync(IList<T> entities)
        {
            await _set.AddRangeAsync(entities);
            return entities;
        }
        
        public T Update(T entity)
        {
            _set.Update(entity);
            return entity;
        }

        public IList<T> UpdateRange(IList<T> entities)
        {
            _set.UpdateRange(entities);
            return entities;
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public void DeleteRange(IList<T> entities)
        {
            _set.RemoveRange(entities);
        }

    }

}
