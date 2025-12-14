using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClientePfRepository : Repository<ClientePf>, IClientePfRepository
    {
        public ClientePfRepository(OficinaContext context) : base(context)
        {
        }
    }
}
