using Core.Shared.ModelViews;
using FluentValidation;

namespace Manager.Validator
{
    public class NovoEnderecoValidator : AbstractValidator<NovoEndereco>
    {
        public NovoEnderecoValidator()
        {
            RuleFor(p => p.Cidade).NotNull().NotEmpty().MaximumLength(200);
        }
    }
}
