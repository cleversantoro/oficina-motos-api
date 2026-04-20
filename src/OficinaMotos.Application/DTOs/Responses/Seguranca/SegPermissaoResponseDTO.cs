namespace OficinaMotos.Application.DTOs.Responses.Seguranca
{
    public class SegPermissaoResponseDTO
    {
        public long Id { get; set; }
        public long ModuloId { get; set; }
        public string NomeModulo { get; set; } = string.Empty;
        public string Acao { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
