using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorRepresentanteValidator : AbstractValidator<UpdateFornecedorRepresentanteDTO>
    {
        public UpdateFornecedorRepresentanteValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(160);
            RuleFor(x => x.Cargo).MaximumLength(100);
            RuleFor(x => x.Email).MaximumLength(160);
            RuleFor(x => x.Telefone).MaximumLength(40);
            RuleFor(x => x.Celular).MaximumLength(40);
            RuleFor(x => x.PreferenciaContato).MaximumLength(60);
            RuleFor(x => x.Observacoes).MaximumLength(500);
        }
    }
}
