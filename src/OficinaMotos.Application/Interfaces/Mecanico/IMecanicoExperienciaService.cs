using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoExperienciaService
    {
        Task<List<MecanicoExperienciaResponseDTO>> GetAllAsync();
        Task<MecanicoExperienciaResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoExperienciaResponseDTO> CreateAsync(CreateMecanicoExperienciaDTO request);
        Task<MecanicoExperienciaResponseDTO?> UpdateAsync(long id, UpdateMecanicoExperienciaDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
