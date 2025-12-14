namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class UpdateMecanicoEnderecoDTO
    {
        public long MecanicoId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string? Pais { get; set; }
        public string? Complemento { get; set; }
        public bool Principal { get; set; }
    }
}
