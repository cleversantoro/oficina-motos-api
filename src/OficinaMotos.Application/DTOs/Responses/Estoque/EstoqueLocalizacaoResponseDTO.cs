namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoqueLocalizacaoResponseDTO
    {
        public long Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string? Corredor { get; set; }
        public string? Prateleira { get; set; }
    }
}
