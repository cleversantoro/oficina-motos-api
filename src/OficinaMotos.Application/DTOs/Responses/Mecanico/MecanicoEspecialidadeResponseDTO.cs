namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoEspecialidadeResponseDTO
    {
        public long Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
