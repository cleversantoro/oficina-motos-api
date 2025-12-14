using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoquePecaAnexoService
    {
        Task<List<EstoquePecaAnexoResponseDTO>> GetAllAsync();
        Task<EstoquePecaAnexoResponseDTO?> GetByIdAsync(long id);
        Task<EstoquePecaAnexoResponseDTO> CreateAsync(CreateEstoquePecaAnexoDTO request);
        Task<EstoquePecaAnexoResponseDTO?> UpdateAsync(long id, UpdateEstoquePecaAnexoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
