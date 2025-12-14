namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class UpdateEstoqueLocalizacaoDTO
    {
        public string Descricao { get; set; } = string.Empty;
        public string? Corredor { get; set; }
        public string? Prateleira { get; set; }
    }
}
