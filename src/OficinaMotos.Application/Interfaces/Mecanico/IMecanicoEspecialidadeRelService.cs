using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoEspecialidadeRelService
    {
        Task<List<MecanicoEspecialidadeRelResponseDTO>> GetAllAsync();
        Task<MecanicoEspecialidadeRelResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoEspecialidadeRelResponseDTO> CreateAsync(CreateMecanicoEspecialidadeRelDTO request);
        Task<MecanicoEspecialidadeRelResponseDTO?> UpdateAsync(long id, UpdateMecanicoEspecialidadeRelDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
