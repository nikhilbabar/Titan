using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Titan.Domain.Relational;

namespace Titan.Data.Relational
{
    public class RelationalContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Search> Searches { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                /// 
                /// To protect potentially sensitive information in your connection string, 
                /// you should move it out of source code. 
                /// See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                /// 
                builder.UseSqlServer(@"Server=(local);Database=Titan;Trusted_Connection=True;");
            }
        }


    }
}
