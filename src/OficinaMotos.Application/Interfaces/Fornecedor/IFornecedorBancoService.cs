using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorBancoService
    {
        Task<List<FornecedorBancoResponseDTO>> GetAllAsync();
        Task<FornecedorBancoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorBancoResponseDTO> CreateAsync(CreateFornecedorBancoDTO request);
        Task<FornecedorBancoResponseDTO?> UpdateAsync(long id, UpdateFornecedorBancoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
