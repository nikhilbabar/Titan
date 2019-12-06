using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Titan.Repository
{
    public interface IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        DbSet<TEntity> GetRepository<TEntity>() where TEntity : class;
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        bool Save();
    }
}
