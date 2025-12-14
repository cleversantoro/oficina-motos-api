namespace OficinaMotos.Application.DTOs.Requests.Fornecedor
{
    public class CreateFornecedorContatoDTO
    {
        public long FornecedorId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
