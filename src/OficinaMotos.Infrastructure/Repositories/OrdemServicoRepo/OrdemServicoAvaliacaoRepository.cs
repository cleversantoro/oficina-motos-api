using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.OrdemServicoRepo
{
    public class OrdemServicoAvaliacaoRepository : Repository<OrdemServicoAvaliacao>, IOrdemServicoAvaliacaoRepository
    {
        public OrdemServicoAvaliacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
