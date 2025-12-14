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
    public class ClientePjService : IClientePjService
    {
        private readonly IClientePjRepository _repository;
        private readonly IMapper _mapper;

        public ClientePjService(IClientePjRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClientePjResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClientePjResponseDTO>>(items);
        }

        public async Task<ClientePjResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClientePjResponseDTO?>(item);
        }

        public async Task<ClientePjResponseDTO> CreateAsync(CreateClientePjDTO request)
        {
            var entity = _mapper.Map<ClientePj>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClientePjResponseDTO>(created);
        }

        public async Task<ClientePjResponseDTO?> UpdateAsync(long id, UpdateClientePjDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Cnpj = request.Cnpj;
            entity.RazaoSocial = request.RazaoSocial;
            entity.NomeFantasia = request.NomeFantasia;
            entity.InscricaoEstadual = request.InscricaoEstadual;
            entity.InscricaoMunicipal = request.InscricaoMunicipal;
            entity.Responsavel = request.Responsavel;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClientePjResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
