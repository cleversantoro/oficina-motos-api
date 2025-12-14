using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroMetodoPagamentoRepository : Repository<FinanceiroMetodoPagamento>, IFinanceiroMetodoPagamentoRepository
    {
        public FinanceiroMetodoPagamentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
