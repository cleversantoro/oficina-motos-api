using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoPagamentoRepository : Repository<OrdemServicoPagamento>, IOrdemServicoPagamentoRepository
    {
        public OrdemServicoPagamentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
