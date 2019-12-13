using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Titan.Common.Utilities
{
    public static class ConfigurationUtility
    {
        public static Dictionary<string, string> ConnectionStrings { get; } = new Dictionary<string, string>();

        public static void SetConnectionStrings(IConfiguration configuration)
        {
            var connections  = configuration.GetSection("ConnectionStrings").AsEnumerable();
            foreach (var connection in connections)
            {
                var items = connection.Key.Split(":");
                if (items.Length > 1) {
                    ConnectionStrings.Add(items[1], connection.Value);
                }
            }
        }
    }
}
