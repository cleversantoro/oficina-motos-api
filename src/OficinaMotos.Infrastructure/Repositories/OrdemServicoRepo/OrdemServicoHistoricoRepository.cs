using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoHistoricoRepository : Repository<OrdemServicoHistorico>, IOrdemServicoHistoricoRepository
    {
        public OrdemServicoHistoricoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
