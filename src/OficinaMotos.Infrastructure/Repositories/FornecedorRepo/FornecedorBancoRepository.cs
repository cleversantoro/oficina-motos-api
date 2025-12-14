using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorBancoRepository : Repository<FornecedorBanco>, IFornecedorBancoRepository
    {
        public FornecedorBancoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
