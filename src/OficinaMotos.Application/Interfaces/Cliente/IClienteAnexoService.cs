using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClienteAnexoService
    {
        Task<List<ClienteAnexoResponseDTO>> GetAllAsync();
        Task<ClienteAnexoResponseDTO?> GetByIdAsync(long id);
        Task<ClienteAnexoResponseDTO> CreateAsync(CreateClienteAnexoDTO request);
        Task<ClienteAnexoResponseDTO?> UpdateAsync(long id, UpdateClienteAnexoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
