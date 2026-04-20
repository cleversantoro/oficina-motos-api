using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories.SegurancaRepo
{
    public class SegUsuarioPerfilRepository : Repository<SegUsuarioPerfil>, ISegUsuarioPerfilRepository
    {
        public SegUsuarioPerfilRepository(OficinaContext context) : base(context) { }

        public async Task<List<SegUsuarioPerfil>> GetByUsuarioAsync(long usuarioId)
            => await _dbSet.Where(up => up.UsuarioId == usuarioId).Include(up => up.Perfil).AsNoTracking().ToListAsync();

        public async Task<SegUsuarioPerfil?> GetByUsuarioAndPerfilAsync(long usuarioId, long perfilId)
            => await _dbSet.FirstOrDefaultAsync(up => up.UsuarioId == usuarioId && up.PerfilId == perfilId);
    }
}
