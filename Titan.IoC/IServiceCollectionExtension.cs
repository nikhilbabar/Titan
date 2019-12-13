using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Titan.Common.Utilities;
using Titan.Data.Relational;
using Titan.DataFactory.File;
using Titan.Repository;
using Titan.Repository.Interface;
using Titan.Service;
using Titan.Service.Interface;

namespace Titan.IoC
{
    public static class IServiceCollectionExtension
    {

        /// * Service lifetimes
        /// Choose an appropriate lifetime for each registered service. 
        /// Services can be configured with the following lifetimes:
        /// 
        /// 1. Transient
        /// Transient lifetime services are created each time they're requested 
        /// from the service container. This lifetime works best for lightweight, 
        /// stateless services.
        /// 
        /// 2. Scoped
        /// Scoped lifetime services are created once per client request(connection).
        /// * Warning
        /// When using a scoped service in a middleware, inject the service into the 
        /// Invoke or InvokeAsync method. Don't inject via constructor injection because 
        /// it forces the service to behave like a singleton. 
        /// 
        /// 3. Singleton
        /// Singleton lifetime services are created the first time they're requested. 
        /// Every subsequent request uses the same instance. If the app requires 
        /// singleton behavior, allowing the service container to manage the service's 
        /// lifetime is recommended. Don't implement the singleton design pattern and 
        /// provide user code to manage the object's lifetime in the class.
        /// * Warning
        /// It's dangerous to resolve a scoped service from a singleton. It may cause 
        /// the service to have incorrect state when processing subsequent requests.
        /// 

        public static IServiceCollection AddDataFactories(this IServiceCollection services)
        {
            var connectionString = ConfigurationUtility.ConnectionStrings["TitanConnection"];
            services.AddDbContext<RelationalContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFileReader, JsonReader>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDatumService, DatumService>();
            services.AddTransient<IUserTypeService, UserTypeService>();
            return services;
        }
    }

}
