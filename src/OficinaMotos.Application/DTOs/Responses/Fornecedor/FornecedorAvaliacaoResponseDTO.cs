using System;

namespace OficinaMotos.Application.DTOs.Responses.Fornecedor
{
    public class FornecedorAvaliacaoResponseDTO
    {
        public long Id { get; set; }
        public long FornecedorId { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public string? AvaliadoPor { get; set; }
        public string? Categoria { get; set; }
        public decimal Nota { get; set; }
        public string? Comentarios { get; set; }
    }
}
