using System;

namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoDocumentoResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? OrgaoExpedidor { get; set; }
        public string? ArquivoUrl { get; set; }
    }
}
