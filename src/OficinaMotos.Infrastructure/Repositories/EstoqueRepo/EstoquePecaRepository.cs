using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;
using System.Threading.Tasks;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoquePecaRepository : Repository<EstoquePeca>, IEstoquePecaRepository
    {
        public EstoquePecaRepository(OficinaContext context) : base(context)
        {
        }

        public async Task<bool> ExistsByCodigoAsync(string codigo)
        {
            return await _dbSet.AnyAsync(p => p.Codigo == codigo);
        }
    }
}
