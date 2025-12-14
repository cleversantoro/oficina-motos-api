using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class CreateFinanceiroLancamentoValidator : AbstractValidator<CreateFinanceiroLancamentoDTO>
    {
        public CreateFinanceiroLancamentoValidator()
        {
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Descricao).NotEmpty().MaximumLength(240);
            RuleFor(x => x.Referencia).MaximumLength(120);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
