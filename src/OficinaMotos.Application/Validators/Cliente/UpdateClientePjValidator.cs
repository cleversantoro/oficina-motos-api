using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class UpdateClientePjValidator : AbstractValidator<UpdateClientePjDTO>
    {
        public UpdateClientePjValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Cnpj).NotEmpty().MaximumLength(30);
            RuleFor(x => x.RazaoSocial).NotEmpty().MaximumLength(200);
            RuleFor(x => x.NomeFantasia).MaximumLength(200);
            RuleFor(x => x.InscricaoEstadual).MaximumLength(60);
            RuleFor(x => x.InscricaoMunicipal).MaximumLength(60);
            RuleFor(x => x.Responsavel).MaximumLength(150);
        }
    }
}
