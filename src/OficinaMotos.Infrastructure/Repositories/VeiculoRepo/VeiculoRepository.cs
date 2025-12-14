using Microsoft.EntityFrameworkCore;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.VeiculoRepo;
using OficinaMotos.Infrastructure.Context;
using VeiculoEntity = OficinaMotos.Domain.Entities.Veiculo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OficinaMotos.Infrastructure.Repositories.Veiculo
{
    public class VeiculoRepository : Repository<VeiculoEntity>, IVeiculoRepository
    {
        public VeiculoRepository(OficinaContext context) : base(context)
        {
        }

        public override async Task<List<VeiculoEntity>> GetAllAsync()
        {
            return await _dbSet
                .Include(v => v.Modelo)
                .AsNoTracking()
                .ToListAsync();
        }

        public override async Task<VeiculoEntity?> GetByIdAsync(long id)
        {
            return await _dbSet
                .Include(v => v.Modelo)
                .AsNoTracking()
                .FirstOrDefaultAsync(v => v.Id == id);
        }
    }
}
