using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class CreateFinanceiroContaPagarValidator : AbstractValidator<CreateFinanceiroContaPagarDTO>
    {
        public CreateFinanceiroContaPagarValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().MaximumLength(240);
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
