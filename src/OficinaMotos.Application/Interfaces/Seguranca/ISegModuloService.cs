using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.Interfaces.Seguranca
{
    public interface ISegModuloService
    {
        Task<List<SegModuloResponseDTO>> GetAllAsync();
        Task<List<SegModuloResponseDTO>> GetAtivosAsync();
        Task<SegModuloResponseDTO?> GetByIdAsync(long id);
        Task<SegModuloResponseDTO> CreateAsync(CreateSegModuloDTO request);
        Task<SegModuloResponseDTO?> UpdateAsync(long id, UpdateSegModuloDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
