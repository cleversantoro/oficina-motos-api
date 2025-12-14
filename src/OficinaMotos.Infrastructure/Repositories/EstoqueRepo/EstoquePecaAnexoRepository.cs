using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoquePecaAnexoRepository : Repository<EstoquePecaAnexo>, IEstoquePecaAnexoRepository
    {
        public EstoquePecaAnexoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
