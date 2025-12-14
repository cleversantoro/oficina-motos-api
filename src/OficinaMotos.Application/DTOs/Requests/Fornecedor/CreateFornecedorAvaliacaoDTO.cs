using System;

namespace OficinaMotos.Application.DTOs.Requests.Fornecedor
{
    public class CreateFornecedorAvaliacaoDTO
    {
        public long FornecedorId { get; set; }
        public DateTime DataAvaliacao { get; set; } = DateTime.UtcNow;
        public string? AvaliadoPor { get; set; }
        public string? Categoria { get; set; }
        public decimal Nota { get; set; }
        public string? Comentarios { get; set; }
    }
}
