using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.FinanceiroRepo
{
    public class FinanceiroAnexoRepository : Repository<FinanceiroAnexo>, IFinanceiroAnexoRepository
    {
        public FinanceiroAnexoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
