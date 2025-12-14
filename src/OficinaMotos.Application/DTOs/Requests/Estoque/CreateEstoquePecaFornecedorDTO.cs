namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class CreateEstoquePecaFornecedorDTO
    {
        public long PecaId { get; set; }
        public long FornecedorId { get; set; }
        public decimal? Preco { get; set; }
        public int? PrazoEntrega { get; set; }
        public string? Observacao { get; set; }
    }
}
