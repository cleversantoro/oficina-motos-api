using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class UpdateFinanceiroPagamentoValidator : AbstractValidator<UpdateFinanceiroPagamentoDTO>
    {
        public UpdateFinanceiroPagamentoValidator()
        {
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
