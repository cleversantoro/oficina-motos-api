namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoEspecialidadeRelResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public long EspecialidadeId { get; set; }
        public string Nivel { get; set; } = "Pleno";
        public bool Principal { get; set; }
        public string? Anotacoes { get; set; }
    }
}
