using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorCertificacaoRepository : Repository<FornecedorCertificacao>, IFornecedorCertificacaoRepository
    {
        public FornecedorCertificacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
