namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoquePecaFornecedorResponseDTO
    {
        public long Id { get; set; }
        public long PecaId { get; set; }
        public long FornecedorId { get; set; }
        public decimal? Preco { get; set; }
        public int? PrazoEntrega { get; set; }
        public string? Observacao { get; set; }
    }
}
