using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Application.DTOs.Responses.Cliente
{
    public class ClienteResponseDTO
    {
        public long Id { get; set; }
        public long Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string NomeExibicao { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string Documento { get; set; } = string.Empty;
        public ClienteTipo Tipo { get; set; } = ClienteTipo.PessoaFisica;
        public ClienteStatus Status { get; set; } = ClienteStatus.Ativo;
        public bool Vip { get; set; }
        public string? Observacoes { get; set; }
        public int OrigemCadastroId { get; set; }
        public long? OrigemId { get; set; }
        public ClienteOrigem? Origem { get; set; }

        public ClientePf? PessoaFisica { get; set; }
        public ClientePj? PessoaJuridica { get; set; }
        public ClienteFinanceiro? Financeiro { get; set; }

        public ICollection<ClienteAnexo> Anexos { get; set; } = new HashSet<ClienteAnexo>();
        public ICollection<ClienteContato> Contatos { get; set; } = new HashSet<ClienteContato>();
        public ICollection<ClienteDocumento> Documentos { get; set; } = new HashSet<ClienteDocumento>();
        public ICollection<ClienteEndereco> Enderecos { get; set; } = new HashSet<ClienteEndereco>();
        public ICollection<ClienteIndicacao> Indicacoes { get; set; } = new HashSet<ClienteIndicacao>();
        public ICollection<ClienteLgpdConsentimento> ConsentimentosLgpd { get; set; } = new HashSet<ClienteLgpdConsentimento>();

        public ICollection<Veiculo> Veiculos { get; set; } = new HashSet<Veiculo>();
        public ICollection<OrdemServico> OrdensServico { get; set; } = new HashSet<OrdemServico>();

        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
    }
}
