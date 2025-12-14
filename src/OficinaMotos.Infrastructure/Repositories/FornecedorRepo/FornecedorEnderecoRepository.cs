using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorEnderecoRepository : Repository<FornecedorEndereco>, IFornecedorEnderecoRepository
    {
        public FornecedorEnderecoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
