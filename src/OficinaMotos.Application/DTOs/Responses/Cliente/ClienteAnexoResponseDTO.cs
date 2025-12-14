namespace OficinaMotos.Application.DTOs.Responses
{
    public class ClienteAnexoResponseDTO
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string? Observacao { get; set; }
    }
}
