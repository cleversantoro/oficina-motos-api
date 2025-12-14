using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using OficinaMotos.Application.Interfaces.Financeiro;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.FinanceiroRepo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Services.Financeiro
{
    public class FinanceiroContaPagarService : IFinanceiroContaPagarService
    {
        private readonly IFinanceiroContaPagarRepository _repository;
        private readonly IMapper _mapper;

        public FinanceiroContaPagarService(IFinanceiroContaPagarRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FinanceiroContaPagarResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FinanceiroContaPagarResponseDTO>>(items);
        }

        public async Task<FinanceiroContaPagarResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FinanceiroContaPagarResponseDTO?>(item);
        }

        public async Task<FinanceiroContaPagarResponseDTO> CreateAsync(CreateFinanceiroContaPagarDTO request)
        {
            var entity = _mapper.Map<FinanceiroContaPagar>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FinanceiroContaPagarResponseDTO>(created);
        }

        public async Task<FinanceiroContaPagarResponseDTO?> UpdateAsync(long id, UpdateFinanceiroContaPagarDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.FornecedorId = request.FornecedorId;
            entity.Descricao = request.Descricao;
            entity.Valor = request.Valor;
            entity.Vencimento = request.Vencimento;
            entity.Status = request.Status;
            entity.DataPagamento = request.DataPagamento;
            entity.MetodoId = request.MetodoId;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FinanceiroContaPagarResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
