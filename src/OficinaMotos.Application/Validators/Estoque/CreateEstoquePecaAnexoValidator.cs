using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoquePecaAnexoValidator : AbstractValidator<CreateEstoquePecaAnexoDTO>
    {
        public CreateEstoquePecaAnexoValidator()
        {
            RuleFor(x => x.PecaId).GreaterThan(0);
            RuleFor(x => x.Nome).MaximumLength(200);
            RuleFor(x => x.Tipo).MaximumLength(100);
            RuleFor(x => x.Url).MaximumLength(500);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
