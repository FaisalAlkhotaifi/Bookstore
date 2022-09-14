using Contract.RepoContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServiceRegister
    {
        public static IServiceCollection AddPresistenceServices(
            this IServiceCollection services, 
            IConfiguration configuration
        )
        {
            var ConnectionString = configuration.GetConnectionString("AppDatabase");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));

            services.AddScoped(typeof(IRepo<>), typeof(Repo<>));

            return services;
        }
    }
}
