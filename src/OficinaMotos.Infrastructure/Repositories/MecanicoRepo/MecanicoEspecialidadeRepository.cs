using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoEspecialidadeRepository : Repository<MecanicoEspecialidade>, IMecanicoEspecialidadeRepository
    {
        public MecanicoEspecialidadeRepository(OficinaContext context) : base(context)
        {
        }
    }
}
