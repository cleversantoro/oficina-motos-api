namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class CreateEstoqueMovimentacaoDTO
    {
        public long PecaId { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string? Referencia { get; set; }
        public string? Usuario { get; set; }
    }
}
