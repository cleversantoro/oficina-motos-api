using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroContaReceberRepository : Repository<FinanceiroContaReceber>, IFinanceiroContaReceberRepository
    {
        public FinanceiroContaReceberRepository(OficinaContext context) : base(context)
        {
        }
    }
}
