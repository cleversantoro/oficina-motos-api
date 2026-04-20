using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegAuditLogRepository : IRepository<SegAuditLog>
    {
        Task<List<SegAuditLog>> GetByUsuarioAsync(long usuarioId, int take = 50);
        Task<List<SegAuditLog>> GetRecentAsync(int take = 100);
        Task<(List<SegAuditLog> Items, int Total)> GetPagedAsync(
            int page, int pageSize,
            long? usuarioId = null,
            string? acao = null,
            string? modulo = null,
            DateTime? de = null,
            DateTime? ate = null);
    }
}
