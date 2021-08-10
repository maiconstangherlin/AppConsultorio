using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace WebApi.Configuration.SwaggerConfig
{
    public static class SwaggerConfig
    {

        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {                
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "WebApi",
                        Version = "v1",
                        Description = "API da aplicação de consultório",
                        Contact = new OpenApiContact
                        {
                            Name = "Maicon Stangherlin",
                            Email = "maicon.stangherlin@gmail.com",
                            Url = new Uri("https://github.com/maiconstangherlin")
                        }
                    });

                c.AddFluentValidationRulesScoped();

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                xmlPath = Path.Combine(AppContext.BaseDirectory, "Core.Shared.xml");
                c.IncludeXmlComments(xmlPath);                
            });            
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
        }

    }
}
