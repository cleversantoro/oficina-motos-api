using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class CreateFornecedorSegmentoValidator : AbstractValidator<CreateFornecedorSegmentoDTO>
    {
        public CreateFornecedorSegmentoValidator()
        {
            RuleFor(x => x.Codigo).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Descricao).MaximumLength(300);
        }
    }
}
