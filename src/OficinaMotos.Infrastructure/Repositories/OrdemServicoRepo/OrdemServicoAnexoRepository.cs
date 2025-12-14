using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoAnexoRepository : Repository<OrdemServicoAnexo>, IOrdemServicoAnexoRepository
    {
        public OrdemServicoAnexoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
