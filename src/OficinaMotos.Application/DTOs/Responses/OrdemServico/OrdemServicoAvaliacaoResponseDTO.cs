namespace OficinaMotos.Application.DTOs.Responses.OrdemServicoDTO
{
    public class OrdemServicoAvaliacaoResponseDTO
    {
        public long Id { get; set; }
        public long OrdemServicoId { get; set; }
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public string? Usuario { get; set; }
    }
}
