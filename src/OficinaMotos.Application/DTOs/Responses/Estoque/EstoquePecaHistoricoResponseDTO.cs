using System;

namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoquePecaHistoricoResponseDTO
    {
        public long Id { get; set; }
        public long PecaId { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string? Usuario { get; set; }
        public string? Campo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? ValorNovo { get; set; }
    }
}
