using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoEspecialidadeService
    {
        Task<List<MecanicoEspecialidadeResponseDTO>> GetAllAsync();
        Task<MecanicoEspecialidadeResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoEspecialidadeResponseDTO> CreateAsync(CreateMecanicoEspecialidadeDTO request);
        Task<MecanicoEspecialidadeResponseDTO?> UpdateAsync(long id, UpdateMecanicoEspecialidadeDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
