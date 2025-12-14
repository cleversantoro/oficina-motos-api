namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoqueCategoriaResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
    }
}
