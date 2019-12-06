using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Titan.WebApi
{
    /// <summary>
    /// 1. Defines Main() .
    /// 2. Used as entry point into an application.
    /// 3. Creates the object of class WebHostBuilder and then chain together a series 
    ///    of methods to build the application.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            /// 
            /// Generate response and short circuit the request. i.e. 
            /// 
            /// 3. Creates the object of class WebHostBuilder and then chain together a 
            ///    series of methods to build the application.
            /// Run() 
            /// Is responsible for running the application.
            /// Build() 
            /// Is responsible for building the application.
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// UseStartup() 
        /// Allows to specify the application level configuration class using type parameter.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
