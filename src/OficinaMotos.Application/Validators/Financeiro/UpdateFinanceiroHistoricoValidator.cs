using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Financeiro;

namespace OficinaMotos.Application.Validators.Financeiro
{
    public class UpdateFinanceiroHistoricoValidator : AbstractValidator<UpdateFinanceiroHistoricoDTO>
    {
        public UpdateFinanceiroHistoricoValidator()
        {
            RuleFor(x => x.Entidade).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Usuario).MaximumLength(120);
            RuleFor(x => x.Campo).MaximumLength(120);
            RuleFor(x => x.ValorAntigo).MaximumLength(300);
            RuleFor(x => x.ValorNovo).MaximumLength(300);
        }
    }
}
