using FluentValidation;
using OficinaMotos.Application.DTOs.Requests;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class UpdateClienteEnderecoValidator : AbstractValidator<UpdateClienteEnderecoDTO>
    {
        public UpdateClienteEnderecoValidator()
        {
            RuleFor(x => x.ClienteId).GreaterThan(0);
            RuleFor(x => x.Tipo).GreaterThan(0);
            RuleFor(x => x.Cep).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Logradouro).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Numero).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Bairro).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Cidade).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Estado).NotEmpty().MaximumLength(60);
            RuleFor(x => x.Pais).MaximumLength(80);
            RuleFor(x => x.Complemento).MaximumLength(200);
        }
    }
}
