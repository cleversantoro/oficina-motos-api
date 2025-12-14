namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class CreateEstoqueLocalizacaoDTO
    {
        public string Descricao { get; set; } = string.Empty;
        public string? Corredor { get; set; }
        public string? Prateleira { get; set; }
    }
}
