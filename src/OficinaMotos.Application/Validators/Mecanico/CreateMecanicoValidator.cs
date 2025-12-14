using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Mecanico;

namespace OficinaMotos.Application.Validators.Mecanico
{
    public class CreateMecanicoValidator : AbstractValidator<CreateMecanicoDTO>
    {
        public CreateMecanicoValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Sobrenome).MaximumLength(160);
            RuleFor(x => x.NomeSocial).MaximumLength(160);
            RuleFor(x => x.DocumentoPrincipal).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Status).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Nivel).MaximumLength(50);
            RuleFor(x => x.Observacoes).MaximumLength(500);
        }
    }
}
