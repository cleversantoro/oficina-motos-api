namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class CreateMecanicoEspecialidadeRelDTO
    {
        public long MecanicoId { get; set; }
        public long EspecialidadeId { get; set; }
        public string Nivel { get; set; } = "Pleno";
        public bool Principal { get; set; }
        public string? Anotacoes { get; set; }
    }
}
