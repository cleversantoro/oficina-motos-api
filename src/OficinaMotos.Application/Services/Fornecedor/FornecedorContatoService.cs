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
    public class FornecedorContatoService : IFornecedorContatoService
    {
        private readonly IFornecedorContatoRepository _repository;
        private readonly IMapper _mapper;

        public FornecedorContatoService(IFornecedorContatoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FornecedorContatoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FornecedorContatoResponseDTO>>(items);
        }

        public async Task<FornecedorContatoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FornecedorContatoResponseDTO?>(item);
        }

        public async Task<FornecedorContatoResponseDTO> CreateAsync(CreateFornecedorContatoDTO request)
        {
            var entity = _mapper.Map<FornecedorContato>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FornecedorContatoResponseDTO>(created);
        }

        public async Task<FornecedorContatoResponseDTO?> UpdateAsync(long id, UpdateFornecedorContatoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.FornecedorId = request.FornecedorId;
            entity.Tipo = request.Tipo;
            entity.Valor = request.Valor;
            entity.Principal = request.Principal;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FornecedorContatoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
