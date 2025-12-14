using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorAvaliacaoService
    {
        Task<List<FornecedorAvaliacaoResponseDTO>> GetAllAsync();
        Task<FornecedorAvaliacaoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorAvaliacaoResponseDTO> CreateAsync(CreateFornecedorAvaliacaoDTO request);
        Task<FornecedorAvaliacaoResponseDTO?> UpdateAsync(long id, UpdateFornecedorAvaliacaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
