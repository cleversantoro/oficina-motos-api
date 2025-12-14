namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoqueFabricanteResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
    }
}
