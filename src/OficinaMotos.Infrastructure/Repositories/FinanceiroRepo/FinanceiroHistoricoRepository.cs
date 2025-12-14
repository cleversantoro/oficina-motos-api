using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroHistoricoRepository : Repository<FinanceiroHistorico>, IFinanceiroHistoricoRepository
    {
        public FinanceiroHistoricoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
