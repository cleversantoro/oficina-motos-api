using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;
using OficinaMotos.Application.Interfaces.Seguranca;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;

namespace OficinaMotos.Application.Services.Seguranca
{
    public class SegPerfilService : ISegPerfilService
    {
        private readonly ISegPerfilRepository _repository;
        private readonly ISegPerfilPermissaoRepository _perfilPermissaoRepository;
        private readonly IMapper _mapper;

        public SegPerfilService(
            ISegPerfilRepository repository,
            ISegPerfilPermissaoRepository perfilPermissaoRepository,
            IMapper mapper)
        {
            _repository = repository;
            _perfilPermissaoRepository = perfilPermissaoRepository;
            _mapper = mapper;
        }

        public async Task<List<SegPerfilResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<SegPerfilResponseDTO>>(items);
        }

        public async Task<List<SegPerfilResponseDTO>> GetAtivosAsync()
        {
            var items = await _repository.GetAtivosAsync();
            return _mapper.Map<List<SegPerfilResponseDTO>>(items);
        }

        public async Task<SegPerfilResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetWithPermissoesAsync(id);
            return item == null ? null : _mapper.Map<SegPerfilResponseDTO>(item);
        }

        public async Task<SegPerfilResponseDTO> CreateAsync(CreateSegPerfilDTO request)
        {
            var entity = _mapper.Map<SegPerfil>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<SegPerfilResponseDTO>(created);
        }

        public async Task<SegPerfilResponseDTO?> UpdateAsync(long id, UpdateSegPerfilDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.Nome = request.Nome;
            entity.Descricao = request.Descricao;
            entity.Nivel = request.Nivel;
            entity.Status = request.Status;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<SegPerfilResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }

        public async Task<SegPerfilResponseDTO?> SetPermissoesAsync(long perfilId, SetPerfilPermissoesDTO request)
        {
            var perfil = await _repository.GetByIdAsync(perfilId);
            if (perfil == null) return null;

            await _perfilPermissaoRepository.DeleteByPerfilAsync(perfilId);

            foreach (var permissaoId in request.PermissaoIds.Distinct())
            {
                var vínculo = new SegPerfilPermissao { PerfilId = perfilId, PermissaoId = permissaoId };
                await _perfilPermissaoRepository.AddAsync(vínculo);
            }

            var updated = await _repository.GetWithPermissoesAsync(perfilId);
            return _mapper.Map<SegPerfilResponseDTO>(updated);
        }
    }
}
