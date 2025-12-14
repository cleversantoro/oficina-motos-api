using System;

namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoDisponibilidadeResponseDTO
    {
        public long Id { get; set; }
        public long MecanicoId { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public int CapacidadeAtendimentos { get; set; }
    }
}
