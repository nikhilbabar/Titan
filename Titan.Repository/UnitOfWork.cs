using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using Titan.Data.Relational;
using Titan.Repository.Interface;
//using System.Data.Entity;
//using System.Data.Entity.Validation;

namespace Titan.Repository
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IDisposable where TContext : DbContext, new()
    {
        private readonly TContext _context;
        private bool _disposed;
        private IDbContextTransaction _transaction;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context.Set<TEntity>()).Set;
        }

        public bool Save()
        {
            var isSuccess = false;
            try
            {
                BeginTransaction();
                if (_context.SaveChanges() > 0)
                {
                    isSuccess = true;
                    CommitTransaction();
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                throw ex;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction.Commit();
        }

        public void RollbackTransaction()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}
