using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoDisponibilidadeService
    {
        Task<List<MecanicoDisponibilidadeResponseDTO>> GetAllAsync();
        Task<MecanicoDisponibilidadeResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoDisponibilidadeResponseDTO> CreateAsync(CreateMecanicoDisponibilidadeDTO request);
        Task<MecanicoDisponibilidadeResponseDTO?> UpdateAsync(long id, UpdateMecanicoDisponibilidadeDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
