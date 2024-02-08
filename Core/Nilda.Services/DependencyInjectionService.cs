using Microsoft.Extensions.DependencyInjection;
using Nilda.Services.Interfaces;
using Nilda.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.Services
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(ICountryService), typeof(CountryService));
            return services;
        }
    }
}
