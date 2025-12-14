using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoDocumentoRepository : Repository<MecanicoDocumento>, IMecanicoDocumentoRepository
    {
        public MecanicoDocumentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
