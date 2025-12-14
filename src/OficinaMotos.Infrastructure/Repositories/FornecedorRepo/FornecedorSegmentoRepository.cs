using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Fornecedor
{
    public class FornecedorSegmentoRepository : Repository<FornecedorSegmento>, IFornecedorSegmentoRepository
    {
        public FornecedorSegmentoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
