using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClientePfService
    {
        Task<List<ClientePfResponseDTO>> GetAllAsync();
        Task<ClientePfResponseDTO?> GetByIdAsync(long id);
        Task<ClientePfResponseDTO> CreateAsync(CreateClientePfDTO request);
        Task<ClientePfResponseDTO?> UpdateAsync(long id, UpdateClientePfDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
