using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClienteContatoRepository : Repository<ClienteContato>, IClienteContatoRepository
    {
        public ClienteContatoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
