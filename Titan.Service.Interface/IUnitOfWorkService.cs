using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Service.Interface
{
    public interface IUnitOfWorkService
    {
        Task<bool> SaveAsync();
    }
}
