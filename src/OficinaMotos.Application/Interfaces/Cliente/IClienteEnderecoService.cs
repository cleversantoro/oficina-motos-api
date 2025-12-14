using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClienteEnderecoService
    {
        Task<List<ClienteEnderecoResponseDTO>> GetAllAsync();
        Task<ClienteEnderecoResponseDTO?> GetByIdAsync(long id);
        Task<ClienteEnderecoResponseDTO> CreateAsync(CreateClienteEnderecoDTO request);
        Task<ClienteEnderecoResponseDTO?> UpdateAsync(long id, UpdateClienteEnderecoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
