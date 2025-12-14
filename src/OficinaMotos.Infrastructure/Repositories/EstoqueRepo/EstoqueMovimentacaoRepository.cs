using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoqueMovimentacaoRepository : Repository<EstoqueMovimentacao>, IEstoqueMovimentacaoRepository
    {
        public EstoqueMovimentacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
