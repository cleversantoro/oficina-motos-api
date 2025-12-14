using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorContatoService
    {
        Task<List<FornecedorContatoResponseDTO>> GetAllAsync();
        Task<FornecedorContatoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorContatoResponseDTO> CreateAsync(CreateFornecedorContatoDTO request);
        Task<FornecedorContatoResponseDTO?> UpdateAsync(long id, UpdateFornecedorContatoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
