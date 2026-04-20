using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.DTOs.Responses.Seguranca
{
    public class SegPerfilResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Nivel { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<SegPermissaoResponseDTO> Permissoes { get; set; } = new();
    }
}
