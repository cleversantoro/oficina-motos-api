using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoqueFabricanteService
    {
        Task<List<EstoqueFabricanteResponseDTO>> GetAllAsync();
        Task<EstoqueFabricanteResponseDTO?> GetByIdAsync(long id);
        Task<EstoqueFabricanteResponseDTO> CreateAsync(CreateEstoqueFabricanteDTO request);
        Task<EstoqueFabricanteResponseDTO?> UpdateAsync(long id, UpdateEstoqueFabricanteDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
