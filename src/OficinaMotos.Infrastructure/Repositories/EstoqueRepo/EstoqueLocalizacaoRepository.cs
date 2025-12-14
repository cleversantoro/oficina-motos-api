using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Estoque;
using OficinaMotos.Infrastructure.Context;
using System.Threading.Tasks;

namespace OficinaMotos.Infrastructure.Repositories.Estoque
{
    public class EstoqueLocalizacaoRepository : Repository<EstoqueLocalizacao>, IEstoqueLocalizacaoRepository
    {
        public EstoqueLocalizacaoRepository(OficinaContext context) : base(context)
        {
        }

        public async Task<bool> ExistsByDescricaoAsync(string descricao)
        {
            return await _dbSet.AnyAsync(l => l.Descricao == descricao);
        }
    }
}
