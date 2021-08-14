using FluentValidation.AspNetCore;
using Manager.Validator;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace WebApi.Configuration.SwaggerConfig
{
    public static class FluentValidationConfig
    {

        public static void AddFluentValidationConfig(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(f =>
                {
                    f.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<AlteraClienteValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<NovoEnderecoValidator>();
                    f.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                });
        }

    }
}
