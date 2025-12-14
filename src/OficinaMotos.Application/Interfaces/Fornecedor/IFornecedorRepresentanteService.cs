using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorRepresentanteService
    {
        Task<List<FornecedorRepresentanteResponseDTO>> GetAllAsync();
        Task<FornecedorRepresentanteResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorRepresentanteResponseDTO> CreateAsync(CreateFornecedorRepresentanteDTO request);
        Task<FornecedorRepresentanteResponseDTO?> UpdateAsync(long id, UpdateFornecedorRepresentanteDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
