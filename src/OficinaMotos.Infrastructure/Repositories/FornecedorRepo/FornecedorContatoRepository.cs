using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorContatoRepository : Repository<FornecedorContato>, IFornecedorContatoRepository
    {
        public FornecedorContatoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
