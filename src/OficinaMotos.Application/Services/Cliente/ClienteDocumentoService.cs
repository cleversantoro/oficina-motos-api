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
    public class ClienteDocumentoService : IClienteDocumentoService
    {
        private readonly IClienteDocumentoRepository _repository;
        private readonly IMapper _mapper;

        public ClienteDocumentoService(IClienteDocumentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClienteDocumentoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<ClienteDocumentoResponseDTO>>(items);
        }

        public async Task<ClienteDocumentoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<ClienteDocumentoResponseDTO?>(item);
        }

        public async Task<ClienteDocumentoResponseDTO> CreateAsync(CreateClienteDocumentoDTO request)
        {
            var entity = _mapper.Map<ClienteDocumento>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<ClienteDocumentoResponseDTO>(created);
        }

        public async Task<ClienteDocumentoResponseDTO?> UpdateAsync(long id, UpdateClienteDocumentoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Tipo = request.Tipo;
            entity.Documento = request.Documento;
            entity.DataEmissao = request.DataEmissao;
            entity.DataValidade = request.DataValidade;
            entity.OrgaoExpedidor = request.OrgaoExpedidor;
            entity.Principal = request.Principal;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<ClienteDocumentoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
