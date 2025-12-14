using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoEnderecoRepository : Repository<MecanicoEndereco>, IMecanicoEnderecoRepository
    {
        public MecanicoEnderecoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
