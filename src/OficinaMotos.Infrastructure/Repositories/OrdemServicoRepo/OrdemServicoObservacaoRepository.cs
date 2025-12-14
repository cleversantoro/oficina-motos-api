using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoObservacaoRepository : Repository<OrdemServicoObservacao>, IOrdemServicoObservacaoRepository
    {
        public OrdemServicoObservacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
