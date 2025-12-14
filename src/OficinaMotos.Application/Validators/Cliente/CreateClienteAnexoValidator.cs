using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class CreateClienteAnexoValidator : AbstractValidator<CreateClienteAnexoDTO>
    {
        public CreateClienteAnexoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Url).NotEmpty().MaximumLength(500);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
