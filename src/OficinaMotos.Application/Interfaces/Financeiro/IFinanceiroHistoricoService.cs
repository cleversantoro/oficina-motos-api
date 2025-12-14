using OficinaMotos.Application.DTOs.Requests.Financeiro;
using OficinaMotos.Application.DTOs.Responses.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Financeiro
{
    public interface IFinanceiroHistoricoService
    {
        Task<List<FinanceiroHistoricoResponseDTO>> GetAllAsync();
        Task<FinanceiroHistoricoResponseDTO?> GetByIdAsync(long id);
        Task<FinanceiroHistoricoResponseDTO> CreateAsync(CreateFinanceiroHistoricoDTO request);
        Task<FinanceiroHistoricoResponseDTO?> UpdateAsync(long id, UpdateFinanceiroHistoricoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
