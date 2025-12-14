namespace OficinaMotos.Application.DTOs.Responses.OrdemServicoDTO
{
    public class OrdemServicoChecklistResponseDTO
    {
        public long Id { get; set; }
        public long OrdemServicoId { get; set; }
        public string Item { get; set; } = string.Empty;
        public bool Realizado { get; set; }
        public string? Observacao { get; set; }
    }
}
