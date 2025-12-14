using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoquePecaHistoricoService
    {
        Task<List<EstoquePecaHistoricoResponseDTO>> GetAllAsync();
        Task<EstoquePecaHistoricoResponseDTO?> GetByIdAsync(long id);
        Task<EstoquePecaHistoricoResponseDTO> CreateAsync(CreateEstoquePecaHistoricoDTO request);
        Task<EstoquePecaHistoricoResponseDTO?> UpdateAsync(long id, UpdateEstoquePecaHistoricoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
