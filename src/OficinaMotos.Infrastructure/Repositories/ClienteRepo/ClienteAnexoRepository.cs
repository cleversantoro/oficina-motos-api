using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClienteAnexoRepository : Repository<ClienteAnexo>, IClienteAnexoRepository
    {
        public ClienteAnexoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
