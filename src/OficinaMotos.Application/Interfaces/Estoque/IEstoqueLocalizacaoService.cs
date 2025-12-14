using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoqueLocalizacaoService
    {
        Task<List<EstoqueLocalizacaoResponseDTO>> GetAllAsync();
        Task<EstoqueLocalizacaoResponseDTO?> GetByIdAsync(long id);
        Task<EstoqueLocalizacaoResponseDTO> CreateAsync(CreateEstoqueLocalizacaoDTO request);
        Task<EstoqueLocalizacaoResponseDTO?> UpdateAsync(long id, UpdateEstoqueLocalizacaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
