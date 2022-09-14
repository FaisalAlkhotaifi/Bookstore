using Application.Services.AccountServices;
using Application.Services.CoreServices;
using Application.Services.LookupContracts;
using Application.Utilites.Helper;
using Contract.ApplicationContracts.AccountContracts;
using Contract.ApplicationContracts.CoreContracts;
using Contract.ApplicationContracts.LookupContracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationServiceRegister
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services
        )
        {
            #region Utilities

            services.AddScoped<IPasswordHelper, PasswordHelper>();
            services.AddScoped<ITokenHelper, TokenHelper>();

            #endregion

            #region Services

            // Account Services

            services.AddScoped<IAccountService, AccountService>();

            
            // Core Services

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IBookService, BookService>();


            // Lookup Services

            services.AddScoped<IBookCategoryService, BookCategoryService>();

            #endregion

            return services;
        }
    }
}
