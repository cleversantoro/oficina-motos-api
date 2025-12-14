using System;

namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoquePecaAnexoResponseDTO
    {
        public long Id { get; set; }
        public long PecaId { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public string? Url { get; set; }
        public string? Observacao { get; set; }
        public DateTime? DataUpload { get; set; }
    }
}
