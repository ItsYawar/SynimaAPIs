using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using SYN.Application.Interfaces;
using SYN.Domain.Interfaces;
using SYN.Domain.Options;
using SYN.Infrastructure.Data;
using SYN.Infrastructure.Repositories;
using SYN.Infrastructure.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYN.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
            // Register JwtOptions
            services.Configure<JwtOptions>(configuration.GetSection(JwtOptions.SectionName));

            services.AddDbContext<SynDBContext>((provider, options) =>
            {
                //var connectionStringOptions = provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value;
                //options.UseSqlServer(connectionStringOptions.dbcs);
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.dbcs);
                //options.UseSqlServer(configuraiton.GetConnectionString("dbcs"));
            });
            services.AddScoped<IEmployeeRepositories, EmployeeRepositories>();
            // Register Repositories and Services
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJwtTokenService, JwtTokenService>();
            services.AddScoped<IFormElementRepository, FormElementRepository>();
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerContactsRepository, CustomerContactsRepository>();


            return services;
        }
    }
}
