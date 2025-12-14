using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;

namespace OficinaMotos.Application.Validators.Fornecedor
{
    public class UpdateFornecedorSegmentoRelValidator : AbstractValidator<UpdateFornecedorSegmentoRelDTO>
    {
        public UpdateFornecedorSegmentoRelValidator()
        {
            RuleFor(x => x.FornecedorId).GreaterThan(0);
            RuleFor(x => x.SegmentoId).GreaterThan(0);
            RuleFor(x => x.Observacoes).MaximumLength(300);
        }
    }
}
