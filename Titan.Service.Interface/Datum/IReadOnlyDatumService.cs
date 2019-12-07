using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Titan.Model;

namespace Titan.Service.Interface
{
    public interface IReadOnlyDatumService
    {
        Task<List<DatumModel>> GetAsync();
        Task<DatumModel> GetAsync(int key);
    }
}
