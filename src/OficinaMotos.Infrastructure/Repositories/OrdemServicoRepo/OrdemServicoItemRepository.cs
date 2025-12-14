using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoItemRepository : Repository<OrdemServicoItem>, IOrdemServicoItemRepository
    {
        public OrdemServicoItemRepository(OficinaContext context) : base(context)
        {
        }
    }
}
