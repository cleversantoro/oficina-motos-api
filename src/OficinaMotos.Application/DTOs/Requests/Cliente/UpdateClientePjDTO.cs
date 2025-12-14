namespace OficinaMotos.Application.DTOs.Requests
{
    public class UpdateClientePjDTO
    {
        public long ClienteId { get; set; }
        public string Cnpj { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string? NomeFantasia { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? Responsavel { get; set; }
    }
}
