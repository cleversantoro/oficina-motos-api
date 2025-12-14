using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;

namespace OficinaMotos.Application.Validators.OrdemServico
{
    public class CreateOrdemServicoAvaliacaoValidator : AbstractValidator<CreateOrdemServicoAvaliacaoDTO>
    {
        public CreateOrdemServicoAvaliacaoValidator()
        {
            RuleFor(x => x.OrdemServicoId).GreaterThan(0);
            RuleFor(x => x.Nota).InclusiveBetween(0, 10);
            RuleFor(x => x.Comentario).MaximumLength(500);
            RuleFor(x => x.Usuario).MaximumLength(160);
        }
    }
}
