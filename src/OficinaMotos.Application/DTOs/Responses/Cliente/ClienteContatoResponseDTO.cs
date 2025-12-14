namespace OficinaMotos.Application.DTOs.Responses
{
    public class ClienteContatoResponseDTO
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public int Tipo { get; set; }
        public string Valor { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
