using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model.Common;

namespace Model
{
    public static class ModelServiceRegister
    {
        public static IServiceCollection AddModelServices(
            this IServiceCollection services
        )
        {
            // Config auth mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
