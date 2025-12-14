using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;

namespace OficinaMotos.Application.Validators.OrdemServico
{
    public class CreateOrdemServicoValidator : AbstractValidator<CreateOrdemServicoDTO>
    {
        public CreateOrdemServicoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.MecanicoId).GreaterThan(0);
            RuleFor(x => x.DescricaoProblema).NotEmpty().MaximumLength(500);
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
        }
    }
}
