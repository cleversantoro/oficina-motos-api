namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class CreateOrdemServicoObservacaoDTO
    {
        public long OrdemServicoId { get; set; }
        public string? Usuario { get; set; }
        public string Texto { get; set; } = string.Empty;
    }
}
