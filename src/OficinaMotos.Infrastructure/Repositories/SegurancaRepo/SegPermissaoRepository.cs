using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.SegurancaRepo
{
    public class SegPermissaoRepository : Repository<SegPermissao>, ISegPermissaoRepository
    {
        public SegPermissaoRepository(OficinaContext context) : base(context) { }

        public override async Task<List<SegPermissao>> GetAllAsync()
            => await _dbSet.Include(p => p.Modulo).AsNoTracking().ToListAsync();

        public async Task<List<SegPermissao>> GetByModuloAsync(long moduloId)
            => await _dbSet.Where(p => p.ModuloId == moduloId).Include(p => p.Modulo).AsNoTracking().ToListAsync();

        public async Task<SegPermissao?> GetByModuloAndAcaoAsync(long moduloId, string acao)
            => await _dbSet.FirstOrDefaultAsync(p => p.ModuloId == moduloId && p.Acao == acao);
    }
}
