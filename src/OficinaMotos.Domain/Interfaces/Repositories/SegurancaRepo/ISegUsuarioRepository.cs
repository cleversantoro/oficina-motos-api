using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegUsuarioRepository : IRepository<SegUsuario>
    {
        Task<SegUsuario?> GetByEmailAsync(string email);
        Task<SegUsuario?> GetByLoginAsync(string login);
        Task<SegUsuario?> GetByEmailOrLoginAsync(string emailOrLogin);
        Task<SegUsuario?> GetWithPerfisAsync(long id);
        Task<bool> EmailExistsAsync(string email, long? excludeId = null);
        Task<bool> LoginExistsAsync(string login, long? excludeId = null);
    }
}
