using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo
{
    public interface ISegModuloRepository : IRepository<SegModulo>
    {
        Task<List<SegModulo>> GetAtivosAsync();
        Task<SegModulo?> GetByNomeAsync(string nome);
    }
}
