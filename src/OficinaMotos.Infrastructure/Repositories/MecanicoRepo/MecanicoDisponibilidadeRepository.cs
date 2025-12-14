using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoDisponibilidadeRepository : Repository<MecanicoDisponibilidade>, IMecanicoDisponibilidadeRepository
    {
        public MecanicoDisponibilidadeRepository(OficinaContext context) : base(context)
        {
        }
    }
}
