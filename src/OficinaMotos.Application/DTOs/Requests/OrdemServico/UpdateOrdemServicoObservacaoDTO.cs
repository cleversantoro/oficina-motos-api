namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class UpdateOrdemServicoObservacaoDTO
    {
        public long OrdemServicoId { get; set; }
        public string? Usuario { get; set; }
        public string Texto { get; set; } = string.Empty;
    }
}
