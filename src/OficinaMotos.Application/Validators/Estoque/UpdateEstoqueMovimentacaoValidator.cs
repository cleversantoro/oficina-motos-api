using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class UpdateEstoqueMovimentacaoValidator : AbstractValidator<UpdateEstoqueMovimentacaoDTO>
    {
        public UpdateEstoqueMovimentacaoValidator()
        {
            RuleFor(x => x.PecaId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Referencia).MaximumLength(120);
            RuleFor(x => x.Usuario).MaximumLength(120);
        }
    }
}
