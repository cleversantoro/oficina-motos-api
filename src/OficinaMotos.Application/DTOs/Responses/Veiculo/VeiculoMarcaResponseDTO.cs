namespace OficinaMotos.Application.DTOs.Responses.VeiculoDTO
{
    public class VeiculoMarcaResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Pais { get; set; }
    }
}
