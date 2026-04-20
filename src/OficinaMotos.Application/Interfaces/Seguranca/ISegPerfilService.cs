using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.Interfaces.Seguranca
{
    public interface ISegPerfilService
    {
        Task<List<SegPerfilResponseDTO>> GetAllAsync();
        Task<List<SegPerfilResponseDTO>> GetAtivosAsync();
        Task<SegPerfilResponseDTO?> GetByIdAsync(long id);
        Task<SegPerfilResponseDTO> CreateAsync(CreateSegPerfilDTO request);
        Task<SegPerfilResponseDTO?> UpdateAsync(long id, UpdateSegPerfilDTO request);
        Task<bool> DeleteAsync(long id);
        Task<SegPerfilResponseDTO?> SetPermissoesAsync(long perfilId, SetPerfilPermissoesDTO request);
    }
}
