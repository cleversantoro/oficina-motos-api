using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegPermissaoRepository : IRepository<SegPermissao>
    {
        Task<List<SegPermissao>> GetByModuloAsync(long moduloId);
        Task<SegPermissao?> GetByModuloAndAcaoAsync(long moduloId, string acao);
    }
}
