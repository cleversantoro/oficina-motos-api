using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorSegmentoRelService
    {
        Task<List<FornecedorSegmentoRelResponseDTO>> GetAllAsync();
        Task<FornecedorSegmentoRelResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorSegmentoRelResponseDTO> CreateAsync(CreateFornecedorSegmentoRelDTO request);
        Task<FornecedorSegmentoRelResponseDTO?> UpdateAsync(long id, UpdateFornecedorSegmentoRelDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
