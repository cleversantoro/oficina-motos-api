using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Financeiro
{
    public interface IFinanceiroPagamentoService
    {
        Task<List<FinanceiroPagamentoResponseDTO>> GetAllAsync();
        Task<FinanceiroPagamentoResponseDTO?> GetByIdAsync(long id);
        Task<FinanceiroPagamentoResponseDTO> CreateAsync(CreateFinanceiroPagamentoDTO request);
        Task<FinanceiroPagamentoResponseDTO?> UpdateAsync(long id, UpdateFinanceiroPagamentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
