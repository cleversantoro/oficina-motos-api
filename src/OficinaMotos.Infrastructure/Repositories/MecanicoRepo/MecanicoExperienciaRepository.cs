using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoExperienciaRepository : Repository<MecanicoExperiencia>, IMecanicoExperienciaRepository
    {
        public MecanicoExperienciaRepository(OficinaContext context) : base(context)
        {
        }
    }
}
