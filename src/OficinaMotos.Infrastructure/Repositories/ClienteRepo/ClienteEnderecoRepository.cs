using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Cliente
{
    public class ClienteEnderecoRepository : Repository<ClienteEndereco>, IClienteEnderecoRepository
    {
        public ClienteEnderecoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
