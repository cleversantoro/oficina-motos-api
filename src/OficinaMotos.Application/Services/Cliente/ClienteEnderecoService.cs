using AutoMapper;
using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using OficinaMotos.Application.Interfaces.Cliente;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.ClienteRepo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Services.Cliente
{
    public class ClienteEnderecoService : IClienteEnderecoService
    {
        private readonly IClienteEnderecoRepository _repository;
        private readonly IMapper _mapper;

        public ClienteEnderecoService(IClienteEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClienteEnderecoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClienteEnderecoResponseDTO>>(items);
        }

        public async Task<ClienteEnderecoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClienteEnderecoResponseDTO?>(item);
        }

        public async Task<ClienteEnderecoResponseDTO> CreateAsync(CreateClienteEnderecoDTO request)
        {
            var entity = _mapper.Map<ClienteEndereco>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClienteEnderecoResponseDTO>(created);
        }

        public async Task<ClienteEnderecoResponseDTO?> UpdateAsync(long id, UpdateClienteEnderecoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
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
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClienteEnderecoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
