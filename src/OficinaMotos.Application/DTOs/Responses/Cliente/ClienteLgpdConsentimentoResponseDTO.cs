using System;

namespace OficinaMotos.Application.DTOs.Responses
{
    public class ClienteLgpdConsentimentoResponseDTO
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public int Tipo { get; set; }
        public bool Aceito { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? ValidoAte { get; set; }
        public string? Observacoes { get; set; }
        public string Canal { get; set; } = string.Empty;
    }
}
