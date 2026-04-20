using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.Interfaces.Seguranca
{
    public interface ISegAuditLogService
    {
        Task<SegAuditLogResponseDTO?> GetByIdAsync(long id);
        Task<List<SegAuditLogResponseDTO>> GetByUsuarioAsync(long usuarioId, int take = 50);
        Task<SegAuditLogPagedResponseDTO> GetPagedAsync(
            int page, int pageSize,
            long? usuarioId = null,
            string? acao = null,
            string? modulo = null,
            DateTime? de = null,
            DateTime? ate = null);
    }
}
