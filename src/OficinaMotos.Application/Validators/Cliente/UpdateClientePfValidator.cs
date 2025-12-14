using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class UpdateClientePfValidator : AbstractValidator<UpdateClientePfDTO>
    {
        public UpdateClientePfValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Cpf).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Rg).MaximumLength(20);
            RuleFor(x => x.Genero).MaximumLength(30);
            RuleFor(x => x.EstadoCivil).MaximumLength(30);
            RuleFor(x => x.Profissao).MaximumLength(80);
        }
    }
}
