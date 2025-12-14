using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoEspecialidadeRelRepository : Repository<MecanicoEspecialidadeRel>, IMecanicoEspecialidadeRelRepository
    {
        public MecanicoEspecialidadeRelRepository(OficinaContext context) : base(context)
        {
        }
    }
}
