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
    public class FornecedorEnderecoService : IFornecedorEnderecoService
    {
        private readonly IFornecedorEnderecoRepository _repository;
        private readonly IMapper _mapper;

        public FornecedorEnderecoService(IFornecedorEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FornecedorEnderecoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FornecedorEnderecoResponseDTO>>(items);
        }

        public async Task<FornecedorEnderecoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FornecedorEnderecoResponseDTO?>(item);
        }

        public async Task<FornecedorEnderecoResponseDTO> CreateAsync(CreateFornecedorEnderecoDTO request)
        {
            var entity = _mapper.Map<FornecedorEndereco>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FornecedorEnderecoResponseDTO>(created);
        }

        public async Task<FornecedorEnderecoResponseDTO?> UpdateAsync(long id, UpdateFornecedorEnderecoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.FornecedorId = request.FornecedorId;
            entity.Tipo = request.Tipo;
            entity.Cep = request.Cep;
            entity.Logradouro = request.Logradouro;
            entity.Numero = request.Numero;
            entity.Bairro = request.Bairro;
            entity.Cidade = request.Cidade;
            entity.Estado = request.Estado;
            entity.Pais = request.Pais;
            entity.Complemento = request.Complemento;
            entity.Principal = request.Principal;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FornecedorEnderecoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
