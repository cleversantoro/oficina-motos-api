using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.SegurancaRepo
{
    public class SegPerfilRepository : Repository<SegPerfil>, ISegPerfilRepository
    {
        public SegPerfilRepository(OficinaContext context) : base(context) { }

        public async Task<List<SegPerfil>> GetAtivosAsync()
            => await _dbSet.Where(p => p.Status == 1).OrderBy(p => p.Nivel).AsNoTracking().ToListAsync();

        public async Task<SegPerfil?> GetWithPermissoesAsync(long id)
            => await _dbSet
                .Include(p => p.PerfisPermissoes)
                    .ThenInclude(pp => pp.Permissao)
                        .ThenInclude(perm => perm!.Modulo)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
    }
}
