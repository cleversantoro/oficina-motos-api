using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class UpdateClienteDocumentoValidator : AbstractValidator<UpdateClienteDocumentoDTO>
    {
        public UpdateClienteDocumentoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(80);
            RuleFor(x => x.Documento).NotEmpty().MaximumLength(60);
            RuleFor(x => x.OrgaoExpedidor).MaximumLength(80);
        }
    }
}
