using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Cliente;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class UpdateClienteValidator : AbstractValidator<UpdateClienteDTO>
    {
        public UpdateClienteValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(200);
            RuleFor(x => x.NomeExibicao).MaximumLength(200);
            RuleFor(x => x.Documento).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Email).MaximumLength(200);
            RuleFor(x => x.Telefone).MaximumLength(40);
            RuleFor(x => x.Observacoes).MaximumLength(500);
            RuleFor(x => x.OrigemCadastroId).GreaterThan(0);
        }
    }
}
