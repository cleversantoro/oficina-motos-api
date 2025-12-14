using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorValidator : AbstractValidator<UpdateFornecedorDTO>
    {
        public UpdateFornecedorValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(50);
            RuleFor(x => x.RazaoSocial).NotEmpty().MaximumLength(200);
            RuleFor(x => x.NomeFantasia).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Documento).NotEmpty().MaximumLength(32);
            RuleFor(x => x.Website).MaximumLength(200);
            RuleFor(x => x.Email).MaximumLength(160);
            RuleFor(x => x.TelefonePrincipal).MaximumLength(40);
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
            RuleFor(x => x.CondicaoPagamentoPadrao).MaximumLength(120);
            RuleFor(x => x.Observacoes).MaximumLength(500);
            RuleFor(x => x.PrazoGarantiaPadrao).MaximumLength(120);
            RuleFor(x => x.TermosNegociados).MaximumLength(500);
        }
    }
}
