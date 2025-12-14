namespace OficinaMotos.Application.DTOs.Requests.Veiculo
{
    public class UpdateVeiculoModeloDTO
    {
        public long MarcaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int? AnoInicio { get; set; }
        public int? AnoFim { get; set; }
    }
}
