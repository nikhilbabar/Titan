using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Titan.DataFactory.File
{
    public class JsonReader : IFileReader
    {
        public T Read<T>(string filePath) where T : class
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var data = reader.ReadToEnd();
                var output = JsonConvert.DeserializeObject<T>(data);
                return output;
            }
        }
    }
}
