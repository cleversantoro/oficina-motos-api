using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorSegmentoService
    {
        Task<List<FornecedorSegmentoResponseDTO>> GetAllAsync();
        Task<FornecedorSegmentoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorSegmentoResponseDTO> CreateAsync(CreateFornecedorSegmentoDTO request);
        Task<FornecedorSegmentoResponseDTO?> UpdateAsync(long id, UpdateFornecedorSegmentoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
