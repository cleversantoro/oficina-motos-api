using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Financeiro
{
    public interface IFinanceiroLancamentoService
    {
        Task<List<FinanceiroLancamentoResponseDTO>> GetAllAsync();
        Task<FinanceiroLancamentoResponseDTO?> GetByIdAsync(long id);
        Task<FinanceiroLancamentoResponseDTO> CreateAsync(CreateFinanceiroLancamentoDTO request);
        Task<FinanceiroLancamentoResponseDTO?> UpdateAsync(long id, UpdateFinanceiroLancamentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
