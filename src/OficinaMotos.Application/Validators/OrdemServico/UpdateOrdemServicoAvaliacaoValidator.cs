using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;

namespace OficinaMotos.Application.Validators.OrdemServico
{
    public class UpdateOrdemServicoAvaliacaoValidator : AbstractValidator<UpdateOrdemServicoAvaliacaoDTO>
    {
        public UpdateOrdemServicoAvaliacaoValidator()
        {
            RuleFor(x => x.OrdemServicoId).GreaterThan(0);
            RuleFor(x => x.Nota).InclusiveBetween(0, 10);
            RuleFor(x => x.Comentario).MaximumLength(500);
            RuleFor(x => x.Usuario).MaximumLength(160);
        }
    }
}
