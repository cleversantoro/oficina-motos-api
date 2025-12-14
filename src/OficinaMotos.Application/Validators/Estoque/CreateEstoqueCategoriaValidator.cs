using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Estoque;

namespace OficinaMotos.Application.Validators.Estoque
{
    public class CreateEstoqueCategoriaValidator : AbstractValidator<CreateEstoqueCategoriaDTO>
    {
        public CreateEstoqueCategoriaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(160).WithMessage("Nome deve ter até 160 caracteres");

            RuleFor(x => x.Descricao)
                .MaximumLength(300).WithMessage("Descrição deve ter até 300 caracteres");
        }
    }
}
