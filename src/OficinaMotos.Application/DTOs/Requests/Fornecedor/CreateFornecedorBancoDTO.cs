namespace OficinaMotos.Application.DTOs.Requests.Fornecedor
{
    public class CreateFornecedorBancoDTO
    {
        public long FornecedorId { get; set; }
        public string Banco { get; set; } = string.Empty;
        public string? Agencia { get; set; }
        public string? Conta { get; set; }
        public string? Digito { get; set; }
        public string? TipoConta { get; set; }
        public string? PixChave { get; set; }
        public string? Observacoes { get; set; }
        public bool Principal { get; set; }
    }
}
