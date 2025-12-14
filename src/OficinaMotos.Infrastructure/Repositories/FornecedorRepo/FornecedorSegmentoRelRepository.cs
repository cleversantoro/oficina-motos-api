using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorSegmentoRelRepository : Repository<FornecedorSegmentoRel>, IFornecedorSegmentoRelRepository
    {
        public FornecedorSegmentoRelRepository(OficinaContext context) : base(context)
        {
        }
    }
}
