namespace OficinaMotos.Application.DTOs.Requests
{
    public class CreateClienteAnexoDTO
    {
        public long ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string? Observacao { get; set; }
    }
}
