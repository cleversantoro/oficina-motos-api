using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorDocumentoRepository : Repository<FornecedorDocumento>, IFornecedorDocumentoRepository
    {
        public FornecedorDocumentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
