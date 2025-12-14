namespace OficinaMotos.Application.DTOs.Responses.VeiculoDTO
{
    public class VeiculoModeloResponseDTO
    {
        public long Id { get; set; }
        public long MarcaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int? AnoInicio { get; set; }
        public int? AnoFim { get; set; }
    }
}
