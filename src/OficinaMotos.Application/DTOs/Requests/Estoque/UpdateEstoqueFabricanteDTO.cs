namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class UpdateEstoqueFabricanteDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
    }
}
