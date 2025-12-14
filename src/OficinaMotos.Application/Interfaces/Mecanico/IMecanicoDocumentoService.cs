using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoDocumentoService
    {
        Task<List<MecanicoDocumentoResponseDTO>> GetAllAsync();
        Task<MecanicoDocumentoResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoDocumentoResponseDTO> CreateAsync(CreateMecanicoDocumentoDTO request);
        Task<MecanicoDocumentoResponseDTO?> UpdateAsync(long id, UpdateMecanicoDocumentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
