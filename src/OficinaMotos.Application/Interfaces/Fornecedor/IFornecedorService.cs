using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorService
    {
        Task<List<FornecedorResponseDTO>> GetAllAsync();
        Task<FornecedorResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorResponseDTO> CreateAsync(CreateFornecedorDTO request);
        Task<FornecedorResponseDTO?> UpdateAsync(long id, UpdateFornecedorDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
