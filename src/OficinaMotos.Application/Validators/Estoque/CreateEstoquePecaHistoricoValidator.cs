using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoquePecaHistoricoValidator : AbstractValidator<CreateEstoquePecaHistoricoDTO>
    {
        public CreateEstoquePecaHistoricoValidator()
        {
            RuleFor(x => x.PecaId).GreaterThan(0);
            RuleFor(x => x.Usuario).MaximumLength(120);
            RuleFor(x => x.Campo).MaximumLength(120);
            RuleFor(x => x.ValorAntigo).MaximumLength(300);
            RuleFor(x => x.ValorNovo).MaximumLength(300);
        }
    }
}
