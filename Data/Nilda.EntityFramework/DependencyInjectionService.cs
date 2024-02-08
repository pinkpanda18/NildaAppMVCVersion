using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nilda.EntityFramework;
using Nilda.EntityFrameworkCore.Interfaces;
using Nilda.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddAppRepositories<TAppDbContext>(this IServiceCollection services)
           where TAppDbContext : AppDbContext
        {
            services.AddTransient(typeof(ICountryRepository), typeof(CountryRepository<TAppDbContext>));
            return services;
        }
    }
}
