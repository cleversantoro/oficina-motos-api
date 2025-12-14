using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorContatoValidator : AbstractValidator<UpdateFornecedorContatoDTO>
    {
        public UpdateFornecedorContatoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Valor).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
