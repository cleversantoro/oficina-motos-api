namespace OficinaMotos.Application.DTOs.Responses
{
    public class ClienteOrigemResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
    }
}
