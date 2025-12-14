using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroLancamentoRepository : Repository<FinanceiroLancamento>, IFinanceiroLancamentoRepository
    {
        public FinanceiroLancamentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
