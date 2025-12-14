using System;

namespace OficinaMotos.Application.DTOs.Responses.Financeiro
{
    public class FinanceiroLancamentoResponseDTO
    {
        public long Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
        public string? Referencia { get; set; }
        public string? Observacao { get; set; }
    }
}
