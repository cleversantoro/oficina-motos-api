using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Financeiro
{
    public interface IFinanceiroMetodoPagamentoService
    {
        Task<List<FinanceiroMetodoPagamentoResponseDTO>> GetAllAsync();
        Task<FinanceiroMetodoPagamentoResponseDTO?> GetByIdAsync(long id);
        Task<FinanceiroMetodoPagamentoResponseDTO> CreateAsync(CreateFinanceiroMetodoPagamentoDTO request);
        Task<FinanceiroMetodoPagamentoResponseDTO?> UpdateAsync(long id, UpdateFinanceiroMetodoPagamentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
