namespace OficinaMotos.Application.DTOs.Requests
{
    public class CreateClienteIndicacaoDTO
    {
        public long ClienteId { get; set; }
        public string IndicadorNome { get; set; } = string.Empty;
        public string? IndicadorTelefone { get; set; }
        public string? Observacao { get; set; }
    }
}
