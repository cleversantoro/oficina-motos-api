namespace OficinaMotos.Application.DTOs.Requests.Seguranca
{
    public class CreateSegModuloDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string? Rota { get; set; }
        public long? ModuloPaiId { get; set; }
        public int Ordem { get; set; }
        public bool Ativo { get; set; } = true;
    }

    public class UpdateSegModuloDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string? Rota { get; set; }
        public long? ModuloPaiId { get; set; }
        public int Ordem { get; set; }
        public bool Ativo { get; set; }
    }
}
