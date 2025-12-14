using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorDocumentoService
    {
        Task<List<FornecedorDocumentoResponseDTO>> GetAllAsync();
        Task<FornecedorDocumentoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorDocumentoResponseDTO> CreateAsync(CreateFornecedorDocumentoDTO request);
        Task<FornecedorDocumentoResponseDTO?> UpdateAsync(long id, UpdateFornecedorDocumentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
