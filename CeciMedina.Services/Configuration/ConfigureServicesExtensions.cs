using CeciMedina.Core.Models;
using CeciMedina.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CeciMedina.Services.Configuration
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IPuntoDeVentaService, PuntoDeVentaService>();

            return services;
        }
    }
}