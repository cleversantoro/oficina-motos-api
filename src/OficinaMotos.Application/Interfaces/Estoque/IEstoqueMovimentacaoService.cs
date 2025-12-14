using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoqueMovimentacaoService
    {
        Task<List<EstoqueMovimentacaoResponseDTO>> GetAllAsync();
        Task<EstoqueMovimentacaoResponseDTO?> GetByIdAsync(long id);
        Task<EstoqueMovimentacaoResponseDTO> CreateAsync(CreateEstoqueMovimentacaoDTO request);
        Task<EstoqueMovimentacaoResponseDTO?> UpdateAsync(long id, UpdateEstoqueMovimentacaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
