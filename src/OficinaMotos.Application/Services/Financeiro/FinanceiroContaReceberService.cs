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
    public class FinanceiroContaReceberService : IFinanceiroContaReceberService
    {
        private readonly IFinanceiroContaReceberRepository _repository;
        private readonly IMapper _mapper;

        public FinanceiroContaReceberService(IFinanceiroContaReceberRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FinanceiroContaReceberResponseDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<List<FinanceiroContaReceberResponseDTO>>(items);
        }

        public async Task<FinanceiroContaReceberResponseDTO?> GetByIdAsync(long id)
        {
            var item = await _repository.GetByIdAsync(id);
            return _mapper.Map<FinanceiroContaReceberResponseDTO?>(item);
        }

        public async Task<FinanceiroContaReceberResponseDTO> CreateAsync(CreateFinanceiroContaReceberDTO request)
        {
            var entity = _mapper.Map<FinanceiroContaReceber>(request);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<FinanceiroContaReceberResponseDTO>(created);
        }

        public async Task<FinanceiroContaReceberResponseDTO?> UpdateAsync(long id, UpdateFinanceiroContaReceberDTO request)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;

            entity.ClienteId = request.ClienteId;
            entity.Descricao = request.Descricao;
            entity.Valor = request.Valor;
            entity.Vencimento = request.Vencimento;
            entity.Status = request.Status;
            entity.DataRecebimento = request.DataRecebimento;
            entity.MetodoId = request.MetodoId;
            entity.Observacao = request.Observacao;
            entity.SetUpdated();

            await _repository.UpdateAsync(entity);
            return _mapper.Map<FinanceiroContaReceberResponseDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (!await _repository.ExistsAsync(id)) return false;
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
