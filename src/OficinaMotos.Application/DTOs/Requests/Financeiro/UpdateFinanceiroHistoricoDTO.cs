using System;

namespace OficinaMotos.Application.DTOs.Requests.Financeiro
{
    public class UpdateFinanceiroHistoricoDTO
    {
        public string Entidade { get; set; } = string.Empty;
        public long EntidadeId { get; set; }
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        public string? Usuario { get; set; }
        public string? Campo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? ValorNovo { get; set; }
    }
}
