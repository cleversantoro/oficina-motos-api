using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoContatoService
    {
        Task<List<MecanicoContatoResponseDTO>> GetAllAsync();
        Task<MecanicoContatoResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoContatoResponseDTO> CreateAsync(CreateMecanicoContatoDTO request);
        Task<MecanicoContatoResponseDTO?> UpdateAsync(long id, UpdateMecanicoContatoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
