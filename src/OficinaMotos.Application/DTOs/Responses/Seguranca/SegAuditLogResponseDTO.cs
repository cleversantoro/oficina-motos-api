namespace OficinaMotos.Application.DTOs.Responses.Seguranca
{
    public class SegAuditLogResponseDTO
    {
        public long Id { get; set; }
        public long? UsuarioId { get; set; }
        public string? Login { get; set; }
        public string Acao { get; set; } = string.Empty;
        public string? Modulo { get; set; }
        public string? Tabela { get; set; }
        public string? RegistroId { get; set; }
        public string? Descricao { get; set; }
        public string? DadosAntes { get; set; }
        public string? DadosDepois { get; set; }
        public string? Ip { get; set; }
        public string? UserAgent { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SegAuditLogPagedResponseDTO
    {
        public List<SegAuditLogResponseDTO> Items { get; set; } = new();
        public int Total { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)Total / PageSize);
    }
}
