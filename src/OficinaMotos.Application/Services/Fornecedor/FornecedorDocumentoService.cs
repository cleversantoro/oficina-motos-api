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
    public class FornecedorDocumentoService : IFornecedorDocumentoService
    {
        private readonly IFornecedorDocumentoRepository _repository;
        private readonly IMapper _mapper;

        public FornecedorDocumentoService(IFornecedorDocumentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FornecedorDocumentoResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FornecedorDocumentoResponseDTO>>(items);
        }

        public async Task<FornecedorDocumentoResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FornecedorDocumentoResponseDTO?>(item);
        }

        public async Task<FornecedorDocumentoResponseDTO> CreateAsync(CreateFornecedorDocumentoDTO request)
        {
            var entity = _mapper.Map<FornecedorDocumento>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FornecedorDocumentoResponseDTO>(created);
        }

        public async Task<FornecedorDocumentoResponseDTO?> UpdateAsync(long id, UpdateFornecedorDocumentoDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.FornecedorId = request.FornecedorId;
            entity.Tipo = request.Tipo;
            entity.Numero = request.Numero;
            entity.DataEmissao = request.DataEmissao;
            entity.DataValidade = request.DataValidade;
            entity.OrgaoExpedidor = request.OrgaoExpedidor;
            entity.ArquivoUrl = request.ArquivoUrl;
            entity.Observacoes = request.Observacoes;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FornecedorDocumentoResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
