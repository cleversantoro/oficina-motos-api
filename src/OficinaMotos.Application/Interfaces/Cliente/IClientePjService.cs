using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClientePjService
    {
        Task<List<ClientePjResponseDTO>> GetAllAsync();
        Task<ClientePjResponseDTO?> GetByIdAsync(long id);
        Task<ClientePjResponseDTO> CreateAsync(CreateClientePjDTO request);
        Task<ClientePjResponseDTO?> UpdateAsync(long id, UpdateClientePjDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
