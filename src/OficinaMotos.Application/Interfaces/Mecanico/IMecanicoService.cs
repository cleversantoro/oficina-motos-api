using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoService
    {
        Task<List<MecanicoResponseDTO>> GetAllAsync();
        Task<MecanicoResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoResponseDTO> CreateAsync(CreateMecanicoDTO request);
        Task<MecanicoResponseDTO?> UpdateAsync(long id, UpdateMecanicoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
