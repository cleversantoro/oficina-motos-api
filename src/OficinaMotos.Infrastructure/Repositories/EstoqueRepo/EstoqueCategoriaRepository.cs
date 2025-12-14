using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;
using System.Threading.Tasks;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoqueCategoriaRepository : Repository<EstoqueCategoria>, IEstoqueCategoriaRepository
    {
        public EstoqueCategoriaRepository(OficinaContext context) : base(context)
        {
        }

        public async Task<bool> ExistsByNomeAsync(string nome)
        {
            return await _dbSet.AnyAsync(c => c.Nome == nome);
        }
    }
}
