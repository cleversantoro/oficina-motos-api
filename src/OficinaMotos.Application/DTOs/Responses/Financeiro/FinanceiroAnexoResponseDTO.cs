using System;

namespace OficinaMotos.Application.DTOs.Responses.Financeiro
{
    public class FinanceiroAnexoResponseDTO
    {
        public long Id { get; set; }
        public long? PagamentoId { get; set; }
        public long? ContaPagarId { get; set; }
        public long? ContaReceberId { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public string? Url { get; set; }
        public string? Observacao { get; set; }
        public DateTime? DataUpload { get; set; }
    }
}
