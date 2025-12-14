using System;

namespace OficinaMotos.Application.DTOs.Requests.Financeiro
{
    public class UpdateFinanceiroContaPagarDTO
    {
        public long? FornecedorId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? DataPagamento { get; set; }
        public long? MetodoId { get; set; }
        public string? Observacao { get; set; }
    }
}
