using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorAvaliacaoRepository : Repository<FornecedorAvaliacao>, IFornecedorAvaliacaoRepository
    {
        public FornecedorAvaliacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
