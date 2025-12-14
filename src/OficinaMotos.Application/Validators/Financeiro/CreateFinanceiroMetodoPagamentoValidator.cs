using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class CreateFinanceiroMetodoPagamentoValidator : AbstractValidator<CreateFinanceiroMetodoPagamentoDTO>
    {
        public CreateFinanceiroMetodoPagamentoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Descricao).MaximumLength(300);
        }
    }
}
