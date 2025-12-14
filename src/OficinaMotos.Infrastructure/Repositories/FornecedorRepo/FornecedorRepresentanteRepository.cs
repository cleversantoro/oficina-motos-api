using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorRepresentanteRepository : Repository<FornecedorRepresentante>, IFornecedorRepresentanteRepository
    {
        public FornecedorRepresentanteRepository(OficinaContext context) : base(context)
        {
        }
    }
}
