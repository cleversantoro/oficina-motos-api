using OficinaMotos.Application.DTOs.Requests.Seguranca;
using OficinaMotos.Application.DTOs.Responses.Seguranca;

namespace OficinaMotos.Application.Interfaces.Seguranca
{
    public interface ISegUsuarioService
    {
        Task<List<SegUsuarioResponseDTO>> GetAllAsync();
        Task<List<SegUsuarioTableDTO>> GetAllForTableAsync();
        Task<SegUsuarioResponseDTO?> GetByIdAsync(long id);
        Task<SegUsuarioResponseDTO> CreateAsync(CreateSegUsuarioDTO request, long? criadoPorId = null);
        Task<SegUsuarioResponseDTO?> UpdateAsync(long id, UpdateSegUsuarioDTO request);
        Task<bool> DeleteAsync(long id);
        Task<bool> AlterarSenhaAsync(long id, AlterarSenhaDTO request);
    }
}
