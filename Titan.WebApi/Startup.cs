using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Titan.Common.Utilities;
using Titan.IoC;

namespace Titan.WebApi
{
    /// <summary>
    /// Defines Configure() used to register Middleware components.
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            ConfigurationUtility.SetConnectionStrings(Configuration);

        }

        public IConfiguration Configuration { get; }

        /// This method gets called by the runtime. 
        /// Use this method to add services to the container.
        /// * Configure the services that will be used by application. 
        ///   This method is strongly tight to dependency injection which makes register 
        ///   services available to controller and other components as well.
        /// * This services could be anything from logging class to business classes.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMapper();
            /// Dependency Injection
            services.AddDataFactories();
            services.AddServices();
        }

        /// This method gets called by the runtime. 
        /// Use this method to configure the HTTP request pipeline.
        /// Method that establishes the core HTTP pipeline by registering middleware components.
        /// For e.g. : UseMvc(), UseStaticFiles()
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
