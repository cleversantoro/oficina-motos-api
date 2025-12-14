using System;

namespace OficinaMotos.Application.DTOs.Requests.Estoque
{
    public class CreateEstoquePecaHistoricoDTO
    {
        public long PecaId { get; set; }
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        public string? Usuario { get; set; }
        public string? Campo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? ValorNovo { get; set; }
    }
}
