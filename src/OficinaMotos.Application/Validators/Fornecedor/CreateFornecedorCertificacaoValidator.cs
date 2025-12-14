using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class CreateFornecedorCertificacaoValidator : AbstractValidator<CreateFornecedorCertificacaoDTO>
    {
        public CreateFornecedorCertificacaoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Titulo).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Instituicao).MaximumLength(160);
            RuleFor(x => x.CodigoCertificacao).MaximumLength(120);
            RuleFor(x => x.Escopo).MaximumLength(240);
        }
    }
}
