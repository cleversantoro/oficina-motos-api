using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClienteContatoService
    {
        Task<List<ClienteContatoResponseDTO>> GetAllAsync();
        Task<ClienteContatoResponseDTO?> GetByIdAsync(long id);
        Task<ClienteContatoResponseDTO> CreateAsync(CreateClienteContatoDTO request);
        Task<ClienteContatoResponseDTO?> UpdateAsync(long id, UpdateClienteContatoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
