using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Mecanico;

namespace OficinaMotos.Application.Validators.Mecanico
{
    public class CreateMecanicoEspecialidadeValidator : AbstractValidator<CreateMecanicoEspecialidadeDTO>
    {
        public CreateMecanicoEspecialidadeValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Descricao).MaximumLength(300);
        }
    }
}
