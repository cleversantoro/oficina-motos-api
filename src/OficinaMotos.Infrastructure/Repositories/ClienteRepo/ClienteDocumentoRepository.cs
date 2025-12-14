using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClienteDocumentoRepository : Repository<ClienteDocumento>, IClienteDocumentoRepository
    {
        public ClienteDocumentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
