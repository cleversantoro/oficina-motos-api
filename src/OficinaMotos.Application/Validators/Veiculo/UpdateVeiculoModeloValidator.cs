using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Veiculo;

namespace OficinaMotos.Application.Validators.Veiculo
{
    public class UpdateVeiculoModeloValidator : AbstractValidator<UpdateVeiculoModeloDTO>
    {
        public UpdateVeiculoModeloValidator()
        {
            RuleFor(x => x.MarcaId).GreaterThan(0);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
        }
    }
}
