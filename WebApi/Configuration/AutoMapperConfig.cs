using Manager.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Configuration.SwaggerConfig
{
    public static class AutoMapperConfig
    {

        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NovoClienteMappingProfile), typeof(AlteraClienteMappingProfile));
        }

    }
}
