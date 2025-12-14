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
    public class ClientePfService : IClientePfService
    {
        private readonly IClientePfRepository _repository;
        private readonly IMapper _mapper;

        public ClientePfService(IClientePfRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClientePfResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClientePfResponseDTO>>(items);
        }

        public async Task<ClientePfResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClientePfResponseDTO?>(item);
        }

        public async Task<ClientePfResponseDTO> CreateAsync(CreateClientePfDTO request)
        {
            var entity = _mapper.Map<ClientePf>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClientePfResponseDTO>(created);
        }

        public async Task<ClientePfResponseDTO?> UpdateAsync(long id, UpdateClientePfDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Cpf = request.Cpf;
            entity.Rg = request.Rg;
            entity.DataNascimento = request.DataNascimento;
            entity.Genero = request.Genero;
            entity.EstadoCivil = request.EstadoCivil;
            entity.Profissao = request.Profissao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClientePfResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
