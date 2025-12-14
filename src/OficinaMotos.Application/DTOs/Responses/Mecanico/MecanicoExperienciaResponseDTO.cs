using System;

namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoExperienciaResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public string Empresa { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string? ResumoAtividades { get; set; }
    }
}
