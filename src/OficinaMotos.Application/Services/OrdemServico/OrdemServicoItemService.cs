using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.OrdemServico;
using OficinaMotos.Application.DTOs.Responses.OrdemServicoDTO;
using OficinaMotos.Application.Interfaces.OrdemServico;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.OrdemServicoRepo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Services.OrdemServicoRepo
{
    public class OrdemServicoItemService : IOrdemServicoItemService
    {
        private readonly IOrdemServicoItemRepository _repository;
        private readonly IMapper _mapper;

        public OrdemServicoItemService(IOrdemServicoItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<OrdemServicoItemResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<OrdemServicoItemResponseDTO>>(items);
        }

        public async Task<OrdemServicoItemResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<OrdemServicoItemResponseDTO?>(item);
        }

        public async Task<OrdemServicoItemResponseDTO> CreateAsync(CreateOrdemServicoItemDTO request)
        {
            var entity = _mapper.Map<OrdemServicoItem>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<OrdemServicoItemResponseDTO>(created);
        }

        public async Task<OrdemServicoItemResponseDTO?> UpdateAsync(long id, UpdateOrdemServicoItemDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.OrdemServicoId = request.OrdemServicoId;
            entity.PecaId = request.PecaId;
            entity.Descricao = request.Descricao;
            entity.Quantidade = request.Quantidade;
            entity.ValorUnitario = request.ValorUnitario;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<OrdemServicoItemResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
