using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.DataFactory.File;
using Titan.Model;
using Titan.Service.Interface;

namespace Titan.Service
{
    public class DatumService : IDatumService
    {
        private readonly IFileReader _fileReader;

        public DatumService(IFileReader fileReader)
        {
            _fileReader = fileReader; // new JsonReader();
        }

        public Task<DatumModel> GetAsync(int key)
        {
            return Task.Run(() => Get(key));
        }

        public Task<List<DatumModel>> GetAsync()
        {
            return Task.Run(() => Query());
        }

        public Task<DatumModel> AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DatumModel> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        private DatumModel Get(int key) => Query().SingleOrDefault(x => x.Key == key);

        private List<DatumModel> Query() => _fileReader.Read<List<DatumModel>>(@"D:\Work & Document\Live\Titan\Datum.json");
    }
}
