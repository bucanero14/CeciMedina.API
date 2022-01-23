using CeciMedina.Core.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CeciMedina.Data.Configuration
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}