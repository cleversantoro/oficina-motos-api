namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class UpdateOrdemServicoChecklistDTO
    {
        public long OrdemServicoId { get; set; }
        public string Item { get; set; } = string.Empty;
        public bool Realizado { get; set; }
        public string? Observacao { get; set; }
    }
}
