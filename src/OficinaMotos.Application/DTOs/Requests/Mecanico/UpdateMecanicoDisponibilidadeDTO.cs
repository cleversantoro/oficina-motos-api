using System;

namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class UpdateMecanicoDisponibilidadeDTO
    {
        public long MecanicoId { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public int CapacidadeAtendimentos { get; set; } = 5;
    }
}
