using AutoMapper;
using OficinaMotos.Application.DTOs.Responses.Seguranca;
using OficinaMotos.Application.Interfaces.Seguranca;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;

namespace OficinaMotos.Application.Services.Seguranca
{
    public class SegAuditLogService : ISegAuditLogService
    {
        private readonly ISegAuditLogRepository _repository;
        private readonly IMapper _mapper;

        public SegAuditLogService(ISegAuditLogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<SegAuditLogResponseDTO?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<SegAuditLogResponseDTO>(entity);
        }

        public async Task<List<SegAuditLogResponseDTO>> GetByUsuarioAsync(long usuarioId, int take = 50)
        {
            var items = await _repository.GetByUsuarioAsync(usuarioId, take);
            return _mapper.Map<List<SegAuditLogResponseDTO>>(items);
        }

        public async Task<SegAuditLogPagedResponseDTO> GetPagedAsync(
            int page, int pageSize,
            long? usuarioId = null,
            string? acao = null,
            string? modulo = null,
            DateTime? de = null,
            DateTime? ate = null)
        {
            var (items, total) = await _repository.GetPagedAsync(page, pageSize, usuarioId, acao, modulo, de, ate);
            return new SegAuditLogPagedResponseDTO
            {
                Items = _mapper.Map<List<SegAuditLogResponseDTO>>(items),
                Total = total,
                Page = page,
                PageSize = pageSize,
            };
        }
    }
}
