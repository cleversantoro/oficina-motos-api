using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoquePecaFornecedorRepository : Repository<EstoquePecaFornecedor>, IEstoquePecaFornecedorRepository
    {
        public EstoquePecaFornecedorRepository(OficinaContext context) : base(context)
        {
        }
    }
}
