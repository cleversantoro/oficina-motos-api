using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.SegurancaRepo
{
    public class SegModuloRepository : Repository<SegModulo>, ISegModuloRepository
    {
        public SegModuloRepository(OficinaContext context) : base(context) { }

        public async Task<List<SegModulo>> GetAtivosAsync()
            => await _dbSet.Where(m => m.Ativo).OrderBy(m => m.Ordem).AsNoTracking().ToListAsync();

        public async Task<SegModulo?> GetByNomeAsync(string nome)
            => await _dbSet.FirstOrDefaultAsync(m => m.Nome == nome);
    }
}
