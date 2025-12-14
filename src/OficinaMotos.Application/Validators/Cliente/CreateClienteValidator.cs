using FluentValidation;
using OficinaMotos.Application.DTOs.Requests.Cliente;

namespace OficinaMotos.Application.Validators.Cliente
{
    public class CreateClienteValidator : AbstractValidator<CreateClienteDTO>
    {
        public CreateClienteValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .Length(3, 150).WithMessage("O nome deve ter entre 3 e 150 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O email é obrigatório")
                .EmailAddress().WithMessage("Email inválido");

            RuleFor(x => x.Cpf)
                .NotEmpty().WithMessage("O CPF é obrigatório")
                .Must(ValidarCpf).WithMessage("CPF inválido"); // Método customizado
        }

        private bool ValidarCpf(string cpf)
        {
            // Aqui entraria o algoritmo de validação de CPF (mod11)
            // Para simplificar o exemplo, retornarei true se tiver 11 digitos
            return cpf.Length == 11;
        }
    }
}