using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Extensions
{
    /// <summary>
    /// Extension class for adding Entity Framework Core services to the IServiceCollection.
    /// </summary>
    public static class EntityFrameworkExtension
    {
        /// <summary>
        /// Extension method to add Entity Framework Core services to the IServiceCollection.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddEntityFramework( this IServiceCollection services, IConfiguration configuration)
        {
            // Add Entity Framework Core with SQL Server
            services.AddDbContext<Contexts.DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ProdutosAppBD")));

            // Add other services related to Entity Framework Core here if needed
            return services;
        }
    }
}
