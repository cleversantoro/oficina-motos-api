using System;

namespace OficinaMotos.Application.DTOs.Requests.Financeiro
{
    public class CreateFinanceiroContaReceberDTO
    {
        public long? ClienteId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? DataRecebimento { get; set; }
        public long? MetodoId { get; set; }
        public string? Observacao { get; set; }
    }
}
