using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class UpdateEstoqueLocalizacaoValidator : AbstractValidator<UpdateEstoqueLocalizacaoDTO>
    {
        public UpdateEstoqueLocalizacaoValidator()
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
