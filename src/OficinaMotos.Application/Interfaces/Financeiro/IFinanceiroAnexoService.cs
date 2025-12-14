using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Financeiro
{
    public interface IFinanceiroAnexoService
    {
        Task<List<FinanceiroAnexoResponseDTO>> GetAllAsync();
        Task<FinanceiroAnexoResponseDTO?> GetByIdAsync(long id);
        Task<FinanceiroAnexoResponseDTO> CreateAsync(CreateFinanceiroAnexoDTO request);
        Task<FinanceiroAnexoResponseDTO?> UpdateAsync(long id, UpdateFinanceiroAnexoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
