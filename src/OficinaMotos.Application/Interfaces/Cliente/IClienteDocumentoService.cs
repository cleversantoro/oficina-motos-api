using OficinaMotos.Application.DTOs.Requests;
using OficinaMotos.Application.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Cliente
{
    public interface IClienteDocumentoService
    {
        Task<List<ClienteDocumentoResponseDTO>> GetAllAsync();
        Task<ClienteDocumentoResponseDTO?> GetByIdAsync(long id);
        Task<ClienteDocumentoResponseDTO> CreateAsync(CreateClienteDocumentoDTO request);
        Task<ClienteDocumentoResponseDTO?> UpdateAsync(long id, UpdateClienteDocumentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
