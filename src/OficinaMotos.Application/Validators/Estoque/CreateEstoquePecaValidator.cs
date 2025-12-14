using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoquePecaValidator : AbstractValidator<CreateEstoquePecaDTO>
    {
        public CreateEstoquePecaValidator()
        {
            RuleFor(x => x.Codigo)
                .NotEmpty().WithMessage("Código é obrigatório")
                .MaximumLength(80);

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Descrição é obrigatória")
                .MaximumLength(240);

            RuleFor(x => x.Unidade)
                .MaximumLength(10);

            RuleFor(x => x.Status)
                .MaximumLength(50);

            RuleFor(x => x.Observacoes)
                .MaximumLength(500);
        }
    }
}
