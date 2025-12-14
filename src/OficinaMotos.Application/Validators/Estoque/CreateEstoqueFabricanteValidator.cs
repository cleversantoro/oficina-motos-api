using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoqueFabricanteValidator : AbstractValidator<CreateEstoqueFabricanteDTO>
    {
        public CreateEstoqueFabricanteValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(160);

            RuleFor(x => x.Cnpj)
                .MaximumLength(32);

            RuleFor(x => x.Contato)
                .MaximumLength(160);
        }
    }
}
