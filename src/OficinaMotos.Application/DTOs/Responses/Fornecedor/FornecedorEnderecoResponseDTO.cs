namespace OficinaMotos.Application.DTOs.Responses.Fornecedor
{
    public class FornecedorEnderecoResponseDTO
    {
        public long Id { get; set; }
        public long FornecedorId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string? Cep { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string? Pais { get; set; }
        public string? Complemento { get; set; }
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
