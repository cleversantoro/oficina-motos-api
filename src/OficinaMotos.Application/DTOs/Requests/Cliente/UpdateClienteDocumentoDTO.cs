using System;

namespace OficinaMotos.Application.DTOs.Requests
{
    public class UpdateClienteDocumentoDTO
    {
        public long ClienteId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? OrgaoExpedidor { get; set; }
        public bool Principal { get; set; }
    }
}
