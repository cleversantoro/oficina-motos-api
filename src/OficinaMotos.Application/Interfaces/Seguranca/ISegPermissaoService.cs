using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.Interfaces.Seguranca
{
    public interface ISegPermissaoService
    {
        Task<List<SegPermissaoResponseDTO>> GetAllAsync();
        Task<List<SegPermissaoResponseDTO>> GetByModuloAsync(long moduloId);
        Task<SegPermissaoResponseDTO?> GetByIdAsync(long id);
        Task<SegPermissaoResponseDTO> CreateAsync(CreateSegPermissaoDTO request);
        Task<SegPermissaoResponseDTO?> UpdateAsync(long id, UpdateSegPermissaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
