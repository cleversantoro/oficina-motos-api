using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;

namespace OficinaMotos.Application.Validators.OrdemServico
{
    public class UpdateOrdemServicoItemValidator : AbstractValidator<UpdateOrdemServicoItemDTO>
    {
        public UpdateOrdemServicoItemValidator()
        {
            RuleFor(x => x.OrdemServicoId).GreaterThan(0);
            RuleFor(x => x.Descricao).NotEmpty().MaximumLength(240);
        }
    }
}
