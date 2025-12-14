using System;

namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoCertificacaoResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public long? EspecialidadeId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Instituicao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? CodigoCertificacao { get; set; }
    }
}
