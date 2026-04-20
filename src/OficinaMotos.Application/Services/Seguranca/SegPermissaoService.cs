using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;
using OficinaMotos.Application.Interfaces.Seguranca;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;

namespace OficinaMotos.Application.Services.Seguranca
{
    public class SegPermissaoService : ISegPermissaoService
    {
        private readonly ISegPermissaoRepository _repository;
        private readonly IMapper _mapper;

        public SegPermissaoService(ISegPermissaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SegPermissaoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<SegPermissaoResponseDTO>>(items);
        }

        public async Task<List<SegPermissaoResponseDTO>> GetByModuloAsync(long moduloId)
        {
            var items = await _repository.GetByModuloAsync(moduloId);
            return _mapper.Map<List<SegPermissaoResponseDTO>>(items);
        }

        public async Task<SegPermissaoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return item == null ? null : _mapper.Map<SegPermissaoResponseDTO>(item);
        }

        public async Task<SegPermissaoResponseDTO> CreateAsync(CreateSegPermissaoDTO request)
        {
            var existing = await _repository.GetByModuloAndAcaoAsync(request.ModuloId, request.Acao);
            if (existing != null)
                throw new InvalidOperationException($"Já existe uma permissão '{request.Acao}' para este módulo.");

            var entity = _mapper.Map<SegPermissao>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<SegPermissaoResponseDTO>(created);
        }

        public async Task<SegPermissaoResponseDTO?> UpdateAsync(long id, UpdateSegPermissaoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.Descricao = request.Descricao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<SegPermissaoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
