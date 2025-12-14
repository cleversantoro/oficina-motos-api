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
    public class ClienteContatoService : IClienteContatoService
    {
        private readonly IClienteContatoRepository _repository;
        private readonly IMapper _mapper;

        public ClienteContatoService(IClienteContatoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClienteContatoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClienteContatoResponseDTO>>(items);
        }

        public async Task<ClienteContatoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClienteContatoResponseDTO?>(item);
        }

        public async Task<ClienteContatoResponseDTO> CreateAsync(CreateClienteContatoDTO request)
        {
            var entity = _mapper.Map<ClienteContato>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClienteContatoResponseDTO>(created);
        }

        public async Task<ClienteContatoResponseDTO?> UpdateAsync(long id, UpdateClienteContatoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Tipo = request.Tipo;
            entity.Valor = request.Valor;
            entity.Principal = request.Principal;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClienteContatoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
