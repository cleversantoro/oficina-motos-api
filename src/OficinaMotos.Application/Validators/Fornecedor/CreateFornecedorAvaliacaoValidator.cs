using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class CreateFornecedorAvaliacaoValidator : AbstractValidator<CreateFornecedorAvaliacaoDTO>
    {
        public CreateFornecedorAvaliacaoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.AvaliadoPor).MaximumLength(160);
            RuleFor(x => x.Categoria).MaximumLength(100);
            RuleFor(x => x.Comentarios).MaximumLength(500);
        }
    }
}
