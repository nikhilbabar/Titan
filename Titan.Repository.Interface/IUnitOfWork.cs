using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Repository.Interface
{
    //public interface IUnitOfWork<TContext> where TContext : DbContext, new()
    //{
    //    DbSet<TEntity> GetRepository<TEntity>() where TEntity : class;
    //    void BeginTransaction();
    //    void CommitTransaction();
    //    void RollbackTransaction();
    //    bool Save();
    //}

    public interface IUnitOfWork
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        bool Save();
        Task<bool> SaveAsync();
    }

}
