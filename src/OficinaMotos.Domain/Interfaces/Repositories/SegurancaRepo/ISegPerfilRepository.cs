using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegPerfilRepository : IRepository<SegPerfil>
    {
        Task<SegPerfil?> GetWithPermissoesAsync(long id);
        Task<List<SegPerfil>> GetAtivosAsync();
    }
}
