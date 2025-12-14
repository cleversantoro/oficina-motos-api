using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;

namespace OficinaMotos.Application.Validators.OrdemServico
{
    public class UpdateOrdemServicoChecklistValidator : AbstractValidator<UpdateOrdemServicoChecklistDTO>
    {
        public UpdateOrdemServicoChecklistValidator()
        {
            RuleFor(x => x.OrdemServicoId).GreaterThan(0);
            RuleFor(x => x.Item).NotEmpty().MaximumLength(240);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
