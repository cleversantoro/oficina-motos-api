namespace OficinaMotos.Application.DTOs.Responses.Seguranca
{
    public class SegUsuarioResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string? Telefone { get; set; }
        public string? FotoUrl { get; set; }
        public int Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public DateTime? UltimoLogin { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<SegPerfilResumoDTO> Perfis { get; set; } = new();
    }

    public class SegPerfilResumoDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Nivel { get; set; }
    }

    public class SegUsuarioTableDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public string Perfis { get; set; } = string.Empty;
        public DateTime? UltimoLogin { get; set; }
    }
}
