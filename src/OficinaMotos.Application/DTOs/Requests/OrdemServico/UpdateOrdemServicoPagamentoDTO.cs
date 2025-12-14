using System;

namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class UpdateOrdemServicoPagamentoDTO
    {
        public long OrdemServicoId { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? DataPagamento { get; set; }
        public string? Metodo { get; set; }
        public string? Observacao { get; set; }
    }
}
