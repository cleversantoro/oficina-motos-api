using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegUsuarioPerfilRepository : IRepository<SegUsuarioPerfil>
    {
        Task<List<SegUsuarioPerfil>> GetByUsuarioAsync(long usuarioId);
        Task<SegUsuarioPerfil?> GetByUsuarioAndPerfilAsync(long usuarioId, long perfilId);
    }
}
