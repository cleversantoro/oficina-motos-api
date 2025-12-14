using System;

namespace OficinaMotos.Application.DTOs.Requests.Financeiro
{
    public class CreateFinanceiroLancamentoDTO
    {
        public string Tipo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; } = DateTime.UtcNow;
        public string? Referencia { get; set; }
        public string? Observacao { get; set; }
    }
}
