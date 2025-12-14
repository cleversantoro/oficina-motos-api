namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class CreateMecanicoContatoDTO
    {
        public long MecanicoId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
