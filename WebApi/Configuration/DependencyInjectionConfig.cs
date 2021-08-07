using Data.Repository;
using Manager.Implementation;
using Manager.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Configuration.SwaggerConfig
{
    public static class DependencyInjectionConfig
    {

        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
        }    

    }
}
