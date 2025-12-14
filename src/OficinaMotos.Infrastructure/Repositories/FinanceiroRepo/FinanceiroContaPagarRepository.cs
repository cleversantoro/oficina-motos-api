using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroContaPagarRepository : Repository<FinanceiroContaPagar>, IFinanceiroContaPagarRepository
    {
        public FinanceiroContaPagarRepository(OficinaContext context) : base(context)
        {
        }
    }
}
