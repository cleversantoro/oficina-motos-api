using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class CreateClienteContatoValidator : AbstractValidator<CreateClienteContatoDTO>
    {
        public CreateClienteContatoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Tipo).GreaterThan(0);
            RuleFor(x => x.Valor).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
