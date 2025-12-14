using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class CreateFornecedorBancoValidator : AbstractValidator<CreateFornecedorBancoDTO>
    {
        public CreateFornecedorBancoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Banco).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Agencia).MaximumLength(30);
            RuleFor(x => x.Conta).MaximumLength(30);
            RuleFor(x => x.Digito).MaximumLength(5);
            RuleFor(x => x.TipoConta).MaximumLength(50);
            RuleFor(x => x.PixChave).MaximumLength(160);
            RuleFor(x => x.Observacoes).MaximumLength(240);
        }
    }
}
