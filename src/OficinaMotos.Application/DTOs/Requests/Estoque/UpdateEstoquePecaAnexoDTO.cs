namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class UpdateEstoquePecaAnexoDTO
    {
        public long PecaId { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public string? Url { get; set; }
        public string? Observacao { get; set; }
    }
}
