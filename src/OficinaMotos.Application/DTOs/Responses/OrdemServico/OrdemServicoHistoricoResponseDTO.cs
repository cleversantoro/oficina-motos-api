using System;

namespace OficinaMotos.Application.DTOs.Responses.OrdemServicoDTO
{
    public class OrdemServicoHistoricoResponseDTO
    {
        public long Id { get; set; }
        public long OrdemServicoId { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string? Usuario { get; set; }
        public string? Campo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? ValorNovo { get; set; }
    }
}
