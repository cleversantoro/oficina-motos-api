using OficinaMotos.Application.DTOs.Requests.Mecanico;
using OficinaMotos.Application.DTOs.Responses.Mecanico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Application.Interfaces.Mecanico
{
    public interface IMecanicoCertificacaoService
    {
        Task<List<MecanicoCertificacaoResponseDTO>> GetAllAsync();
        Task<MecanicoCertificacaoResponseDTO?> GetByIdAsync(long id);
        Task<MecanicoCertificacaoResponseDTO> CreateAsync(CreateMecanicoCertificacaoDTO request);
        Task<MecanicoCertificacaoResponseDTO?> UpdateAsync(long id, UpdateMecanicoCertificacaoDTO request);
        Task<bool> DeleteAsync(long id);
    }
}
