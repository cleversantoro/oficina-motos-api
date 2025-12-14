using OficinaMotos.Application.DTOs.Requests.Cliente;
using OficinaMotos.Application.DTOs.Responses.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClienteService
    {
        Task<List<ClienteResponseDTO>> GetAllAsync();
        Task<ClienteResponseDTO?> GetByIdAsync(long id);
        Task<ClienteResponseDTO> CreateAsync(CreateClienteDTO request);
        Task<ClienteResponseDTO?> UpdateAsync(long id, UpdateClienteDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
