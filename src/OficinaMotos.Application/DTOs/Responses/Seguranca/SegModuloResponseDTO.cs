namespace OficinaMotos.Application.DTOs.Responses.Seguranca
{
    public class SegModuloResponseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string? Rota { get; set; }
        public long? ModuloPaiId { get; set; }
        public int Ordem { get; set; }
        public bool Ativo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
