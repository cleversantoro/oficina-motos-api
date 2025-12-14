namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoContatoResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
