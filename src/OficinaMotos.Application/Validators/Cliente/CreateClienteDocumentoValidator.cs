using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class CreateClienteDocumentoValidator : AbstractValidator<CreateClienteDocumentoDTO>
    {
        public CreateClienteDocumentoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(80);
            RuleFor(x => x.Documento).NotEmpty().MaximumLength(60);
            RuleFor(x => x.OrgaoExpedidor).MaximumLength(80);
        }
    }
}
