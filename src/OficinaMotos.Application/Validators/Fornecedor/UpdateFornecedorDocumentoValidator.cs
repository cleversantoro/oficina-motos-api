using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorDocumentoValidator : AbstractValidator<UpdateFornecedorDocumentoDTO>
    {
        public UpdateFornecedorDocumentoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Numero).NotEmpty().MaximumLength(120);
            RuleFor(x => x.OrgaoExpedidor).MaximumLength(120);
            RuleFor(x => x.ArquivoUrl).MaximumLength(500);
            RuleFor(x => x.Observacoes).MaximumLength(240);
        }
    }
}
