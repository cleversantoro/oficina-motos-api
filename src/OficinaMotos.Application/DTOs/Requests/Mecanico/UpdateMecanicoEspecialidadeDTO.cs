namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class UpdateMecanicoEspecialidadeDTO
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
