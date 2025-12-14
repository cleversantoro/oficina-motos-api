namespace OficinaMotos.Application.DTOs.Requests
{
    public class UpdateClienteContatoDTO
    {
        public long ClienteId { get; set; }
        public int Tipo { get; set; }
        public string Valor { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Observacao { get; set; }
    }
}
