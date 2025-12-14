using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoqueCategoriaService
    {
        Task<List<EstoqueCategoriaResponseDTO>> GetAllAsync();
        Task<EstoqueCategoriaResponseDTO?> GetByIdAsync(long id);
        Task<EstoqueCategoriaResponseDTO> CreateAsync(CreateEstoqueCategoriaDTO request);
        Task<EstoqueCategoriaResponseDTO?> UpdateAsync(long id, UpdateEstoqueCategoriaDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
