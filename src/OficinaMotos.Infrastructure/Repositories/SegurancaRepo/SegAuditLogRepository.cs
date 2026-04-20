using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.SegurancaRepo
{
    public class SegAuditLogRepository : Repository<SegAuditLog>, ISegAuditLogRepository
    {
        public SegAuditLogRepository(OficinaContext context) : base(context) { }

        public async Task<List<SegAuditLog>> GetByUsuarioAsync(long usuarioId, int take = 50)
            => await _dbSet
                .Where(al => al.UsuarioId == usuarioId)
                .OrderByDescending(al => al.CreatedAt)
                .Take(take)
                .AsNoTracking()
                .ToListAsync();

        public async Task<List<SegAuditLog>> GetRecentAsync(int take = 100)
            => await _dbSet
                .OrderByDescending(al => al.CreatedAt)
                .Take(take)
                .AsNoTracking()
                .ToListAsync();

        public async Task<(List<SegAuditLog> Items, int Total)> GetPagedAsync(
            int page, int pageSize,
            long? usuarioId = null,
            string? acao = null,
            string? modulo = null,
            DateTime? de = null,
            DateTime? ate = null)
        {
            var query = _dbSet.AsNoTracking().AsQueryable();

            if (usuarioId.HasValue)
                query = query.Where(al => al.UsuarioId == usuarioId);
            if (!string.IsNullOrWhiteSpace(acao))
                query = query.Where(al => al.Acao == acao);
            if (!string.IsNullOrWhiteSpace(modulo))
                query = query.Where(al => al.Modulo == modulo);
            if (de.HasValue)
                query = query.Where(al => al.CreatedAt >= de.Value);
            if (ate.HasValue)
                query = query.Where(al => al.CreatedAt <= ate.Value);

            var total = await query.CountAsync();
            var items = await query
                .OrderByDescending(al => al.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (items, total);
        }
    }
}
