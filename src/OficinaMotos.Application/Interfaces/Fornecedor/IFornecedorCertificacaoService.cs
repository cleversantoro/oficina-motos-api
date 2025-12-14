using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Fornecedor
{
    public interface IFornecedorCertificacaoService
    {
        Task<List<FornecedorCertificacaoResponseDTO>> GetAllAsync();
        Task<FornecedorCertificacaoResponseDTO?> GetByIdAsync(long id);
        Task<FornecedorCertificacaoResponseDTO> CreateAsync(CreateFornecedorCertificacaoDTO request);
        Task<FornecedorCertificacaoResponseDTO?> UpdateAsync(long id, UpdateFornecedorCertificacaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
