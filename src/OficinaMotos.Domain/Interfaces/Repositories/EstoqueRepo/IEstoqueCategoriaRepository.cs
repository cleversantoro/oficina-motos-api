using OficinaMotos.Domain.Entities;
using System.Threading.Tasks;

namespace OficinaMotos.Domain.Interfaces.Repositories.Estoque
{
    public interface IEstoqueCategoriaRepository : IRepository<EstoqueCategoria>
    {
        Task<bool> ExistsByNomeAsync(string nome);
    }
}
