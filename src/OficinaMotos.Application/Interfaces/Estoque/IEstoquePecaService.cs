using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoquePecaService
    {
        Task<List<EstoquePecaResponseDTO>> GetAllAsync();
        Task<EstoquePecaResponseDTO?> GetByIdAsync(long id);
        Task<EstoquePecaResponseDTO> CreateAsync(CreateEstoquePecaDTO request);
        Task<EstoquePecaResponseDTO?> UpdateAsync(long id, UpdateEstoquePecaDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
