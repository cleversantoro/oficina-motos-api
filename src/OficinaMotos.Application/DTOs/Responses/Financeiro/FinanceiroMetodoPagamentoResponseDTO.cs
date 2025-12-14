namespace OficinaMotos.Application.DTOs.Responses.Financeiro
{
    public class FinanceiroMetodoPagamentoResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
    }
}
