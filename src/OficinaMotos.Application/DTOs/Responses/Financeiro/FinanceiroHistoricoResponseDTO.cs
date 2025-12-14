using System;

namespace OficinaMotos.Application.DTOs.Responses.Financeiro
{
    public class FinanceiroHistoricoResponseDTO
    {
        public long Id { get; set; }
        public string Entidade { get; set; } = string.Empty;
        public long EntidadeId { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string? Usuario { get; set; }
        public string? Campo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? ValorNovo { get; set; }
    }
}
