namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class CreateOrdemServicoAnexoDTO
    {
        public long OrdemServicoId { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public string? Url { get; set; }
        public string? Observacao { get; set; }
    }
}
