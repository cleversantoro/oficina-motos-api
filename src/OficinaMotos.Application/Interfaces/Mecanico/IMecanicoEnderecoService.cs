using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoEnderecoService
    {
        Task<List<MecanicoEnderecoResponseDTO>> GetAllAsync();
        Task<MecanicoEnderecoResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoEnderecoResponseDTO> CreateAsync(CreateMecanicoEnderecoDTO request);
        Task<MecanicoEnderecoResponseDTO?> UpdateAsync(long id, UpdateMecanicoEnderecoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
