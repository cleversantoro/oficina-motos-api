namespace OficinaMotos.Application.DTOs.Responses.OrdemServicoDTO
{
    public class OrdemServicoObservacaoResponseDTO
    {
        public long Id { get; set; }
        public long OrdemServicoId { get; set; }
        public string? Usuario { get; set; }
        public string Texto { get; set; } = string.Empty;
    }
}
