using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClienteOrigemRepository : Repository<ClienteOrigem>, IClienteOrigemRepository
    {
        public ClienteOrigemRepository(OficinaContext context) : base(context)
        {
        }
    }
}
