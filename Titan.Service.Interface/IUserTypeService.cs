using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Titan.Model;

namespace Titan.Service.Interface
{
    public interface IUserTypeService
    {
        Task<List<UserTypeModel>> GetAsync();
        Task<UserTypeModel> GetAsync(byte id);

    }
}
