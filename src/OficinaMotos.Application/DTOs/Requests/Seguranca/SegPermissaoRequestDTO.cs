namespace OficinaMotos.Application.DTOs.Requests.Seguranca
{
    public class CreateSegPermissaoDTO
    {
        public long ModuloId { get; set; }
        public string Acao { get; set; } = string.Empty;
        public string? Descricao { get; set; }
    }

    public class UpdateSegPermissaoDTO
    {
        public string? Descricao { get; set; }
    }
}
