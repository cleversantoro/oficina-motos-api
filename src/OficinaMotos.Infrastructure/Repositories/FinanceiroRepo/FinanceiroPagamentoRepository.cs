using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroPagamentoRepository : Repository<FinanceiroPagamento>, IFinanceiroPagamentoRepository
    {
        public FinanceiroPagamentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
