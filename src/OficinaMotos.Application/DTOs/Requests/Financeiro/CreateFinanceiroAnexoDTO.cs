using System;

namespace OficinaMotos.Application.DTOs.Requests.Financeiro
{
    public class CreateFinanceiroAnexoDTO
    {
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
