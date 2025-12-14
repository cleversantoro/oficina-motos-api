using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorEnderecoService
    {
        Task<List<FornecedorEnderecoResponseDTO>> GetAllAsync();
        Task<FornecedorEnderecoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorEnderecoResponseDTO> CreateAsync(CreateFornecedorEnderecoDTO request);
        Task<FornecedorEnderecoResponseDTO?> UpdateAsync(long id, UpdateFornecedorEnderecoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
