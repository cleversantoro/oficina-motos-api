using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClientePjRepository : Repository<ClientePj>, IClientePjRepository
    {
        public ClientePjRepository(OficinaContext context) : base(context)
        {
        }
    }
}
