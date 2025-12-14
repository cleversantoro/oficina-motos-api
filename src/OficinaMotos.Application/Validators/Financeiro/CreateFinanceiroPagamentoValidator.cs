using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class CreateFinanceiroPagamentoValidator : AbstractValidator<CreateFinanceiroPagamentoDTO>
    {
        public CreateFinanceiroPagamentoValidator()
        {
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
