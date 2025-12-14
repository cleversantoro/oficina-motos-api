using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoquePecaHistoricoRepository : Repository<EstoquePecaHistorico>, IEstoquePecaHistoricoRepository
    {
        public EstoquePecaHistoricoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
