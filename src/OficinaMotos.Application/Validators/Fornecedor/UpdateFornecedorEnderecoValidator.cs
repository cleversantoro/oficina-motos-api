using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorEnderecoValidator : AbstractValidator<UpdateFornecedorEnderecoDTO>
    {
        public UpdateFornecedorEnderecoValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Tipo).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Cep).MaximumLength(20);
            RuleFor(x => x.Logradouro).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Numero).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Bairro).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Cidade).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Estado).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Pais).MaximumLength(80);
            RuleFor(x => x.Complemento).MaximumLength(120);
            RuleFor(x => x.Observacao).MaximumLength(240);
        }
    }
}
