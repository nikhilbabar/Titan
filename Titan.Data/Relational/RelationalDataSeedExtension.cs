using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Titan.Domain.Relational;

namespace Titan.Data.Relational
{
    public static class RelationalDataSeedExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<UserType>().HasData(
                new UserType { Id = 1, Name = "Sytem", Code = 1 },
                new UserType { Id = 2, Name = "Sytem", Code = 2 });
        }
    }
}
