using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoqueLocalizacaoValidator : AbstractValidator<CreateEstoqueLocalizacaoDTO>
    {
        public CreateEstoqueLocalizacaoValidator()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Descrição é obrigatória")
                .MaximumLength(200);

            RuleFor(x => x.Corredor)
                .MaximumLength(50);

            RuleFor(x => x.Prateleira)
                .MaximumLength(50);
        }
    }
}
