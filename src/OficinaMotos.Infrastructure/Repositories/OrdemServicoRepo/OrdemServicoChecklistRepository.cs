using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoChecklistRepository : Repository<OrdemServicoChecklist>, IOrdemServicoChecklistRepository
    {
        public OrdemServicoChecklistRepository(OficinaContext context) : base(context)
        {
        }
    }
}
