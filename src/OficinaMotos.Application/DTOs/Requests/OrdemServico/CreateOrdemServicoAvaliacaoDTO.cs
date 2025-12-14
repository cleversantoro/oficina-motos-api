namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class CreateOrdemServicoAvaliacaoDTO
    {
        public long OrdemServicoId { get; set; }
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public string? Usuario { get; set; }
    }
}
