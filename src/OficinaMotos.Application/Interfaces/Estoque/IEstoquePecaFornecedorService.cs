using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Estoque
{
    public interface IEstoquePecaFornecedorService
    {
        Task<List<EstoquePecaFornecedorResponseDTO>> GetAllAsync();
        Task<EstoquePecaFornecedorResponseDTO?> GetByIdAsync(long id);
        Task<EstoquePecaFornecedorResponseDTO> CreateAsync(CreateEstoquePecaFornecedorDTO request);
        Task<EstoquePecaFornecedorResponseDTO?> UpdateAsync(long id, UpdateEstoquePecaFornecedorDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
