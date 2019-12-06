using System;
using System.Collections.Generic;
using System.Text;

namespace Titan.DataFactory.File
{
    public interface IFileReader
    {
        T Read<T>(string filePath) where T : class;
    }
}
