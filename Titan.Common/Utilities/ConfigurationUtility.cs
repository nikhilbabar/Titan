using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Titan.Common.Utilities
{
    public static class ConfigurationUtility
    {
        public static Dictionary<string, string> ConnectionStrings { get; set; }
        

        public static void SetConnectionStrings(IConfiguration configuration)
        {
            var connections  = configuration.GetSection("ConnectionStrings").AsEnumerable();
            foreach (var connection in connections)
            {
                ConnectionStrings.Add(connection.Key, connection.Value);
            }
        }
    }
}
