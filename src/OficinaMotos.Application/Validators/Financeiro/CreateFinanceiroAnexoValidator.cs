using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class CreateFinanceiroAnexoValidator : AbstractValidator<CreateFinanceiroAnexoDTO>
    {
        public CreateFinanceiroAnexoValidator()
        {
            RuleFor(x => x.Nome).MaximumLength(200);
            RuleFor(x => x.Tipo).MaximumLength(100);
            RuleFor(x => x.Url).MaximumLength(500);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
