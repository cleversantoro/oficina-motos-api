using System;

namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class UpdateMecanicoExperienciaDTO
    {
        public long MecanicoId { get; set; }
        public string Empresa { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string? ResumoAtividades { get; set; }
    }
}
