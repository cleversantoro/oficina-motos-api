using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.Mecanico;
using OficinaMotos.Infrastructure.Context;

namespace OficinaMotos.Infrastructure.Repositories
{
    public class MecanicoCertificacaoRepository : Repository<MecanicoCertificacao>, IMecanicoCertificacaoRepository
    {
        public MecanicoCertificacaoRepository(OficinaContext context) : base(context)
        {
        }
    }
}
