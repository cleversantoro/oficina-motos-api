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
    public class ClienteAnexoService : IClienteAnexoService
    {
        private readonly IClienteAnexoRepository _repository;
        private readonly IMapper _mapper;

        public ClienteAnexoService(IClienteAnexoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClienteAnexoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClienteAnexoResponseDTO>>(items);
        }

        public async Task<ClienteAnexoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClienteAnexoResponseDTO?>(item);
        }

        public async Task<ClienteAnexoResponseDTO> CreateAsync(CreateClienteAnexoDTO request)
        {
            var entity = _mapper.Map<ClienteAnexo>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClienteAnexoResponseDTO>(created);
        }

        public async Task<ClienteAnexoResponseDTO?> UpdateAsync(long id, UpdateClienteAnexoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Nome = request.Nome;
            entity.Tipo = request.Tipo;
            entity.Url = request.Url;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClienteAnexoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
