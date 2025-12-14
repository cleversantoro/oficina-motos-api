using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using OficinaMotos.Application.Interfaces.Fornecedor;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Services.Fornecedor
{
    public class FornecedorSegmentoRelService : IFornecedorSegmentoRelService
    {
        private readonly IFornecedorSegmentoRelRepository _repository;
        private readonly IMapper _mapper;

        public FornecedorSegmentoRelService(IFornecedorSegmentoRelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FornecedorSegmentoRelResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FornecedorSegmentoRelResponseDTO>>(items);
        }

        public async Task<FornecedorSegmentoRelResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FornecedorSegmentoRelResponseDTO?>(item);
        }

        public async Task<FornecedorSegmentoRelResponseDTO> CreateAsync(CreateFornecedorSegmentoRelDTO request)
        {
            var entity = _mapper.Map<FornecedorSegmentoRel>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FornecedorSegmentoRelResponseDTO>(created);
        }

        public async Task<FornecedorSegmentoRelResponseDTO?> UpdateAsync(long id, UpdateFornecedorSegmentoRelDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.FornecedorId = request.FornecedorId;
            entity.SegmentoId = request.SegmentoId;
            entity.Principal = request.Principal;
            entity.Observacoes = request.Observacoes;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FornecedorSegmentoRelResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
