using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoContatoRepository : Repository<MecanicoContato>, IMecanicoContatoRepository
    {
        public MecanicoContatoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
