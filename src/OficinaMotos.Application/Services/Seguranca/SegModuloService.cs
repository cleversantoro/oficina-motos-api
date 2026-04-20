using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;
using OficinaMotos.Application.Interfaces.Seguranca;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;

namespace OficinaMotos.Application.Services.Seguranca
{
    public class SegModuloService : ISegModuloService
    {
        private readonly ISegModuloRepository _repository;
        private readonly IMapper _mapper;

        public SegModuloService(ISegModuloRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SegModuloResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<SegModuloResponseDTO>>(items);
        }

        public async Task<List<SegModuloResponseDTO>> GetAtivosAsync()
        {
            var items = await _repository.GetAtivosAsync();
            return _mapper.Map<List<SegModuloResponseDTO>>(items);
        }

        public async Task<SegModuloResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return item == null ? null : _mapper.Map<SegModuloResponseDTO>(item);
        }

        public async Task<SegModuloResponseDTO> CreateAsync(CreateSegModuloDTO request)
        {
            if (await _repository.GetByNomeAsync(request.Nome) != null)
                throw new InvalidOperationException($"Já existe um módulo com o nome '{request.Nome}'.");

            var entity = _mapper.Map<SegModulo>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<SegModuloResponseDTO>(created);
        }

        public async Task<SegModuloResponseDTO?> UpdateAsync(long id, UpdateSegModuloDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.Nome = request.Nome;
            entity.Descricao = request.Descricao;
            entity.Icone = request.Icone;
            entity.Rota = request.Rota;
            entity.ModuloPaiId = request.ModuloPaiId;
            entity.Ordem = request.Ordem;
            entity.Ativo = request.Ativo;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<SegModuloResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
