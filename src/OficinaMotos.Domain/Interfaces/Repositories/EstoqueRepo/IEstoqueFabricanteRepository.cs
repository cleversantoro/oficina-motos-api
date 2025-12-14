using OficinaMotos.Domain.Entities;
using System.Threading.Tasks;

namespace OficinaMotos.Domain.Interfaces.Repositories.Estoque
{
    public interface IEstoqueFabricanteRepository : IRepository<EstoqueFabricante>
    {
        Task<bool> ExistsByNomeAsync(string nome);
    }
}
