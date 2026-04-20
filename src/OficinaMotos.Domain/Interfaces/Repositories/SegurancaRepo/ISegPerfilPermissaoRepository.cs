using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegPerfilPermissaoRepository : IRepository<SegPerfilPermissao>
    {
        Task<List<SegPerfilPermissao>> GetByPerfilAsync(long perfilId);
        Task DeleteByPerfilAsync(long perfilId);
        Task<bool> ExistsAsync(long perfilId, long permissaoId);
    }
}
