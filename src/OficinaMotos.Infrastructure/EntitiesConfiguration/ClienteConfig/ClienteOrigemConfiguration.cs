using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteOrigemConfiguration : IEntityTypeConfiguration<ClienteOrigem>
    {
        public void Configure(EntityTypeBuilder<ClienteOrigem> builder)
        {
            builder.ToTable("cad_clientes_origens");

            builder.HasKey(o => o.Id);

            //builder.Ignore(o => o.IsDeleted);

            builder.Property(o => o.Nome).HasColumnName("Nome").HasMaxLength(120).IsRequired();
            builder.Property(o => o.Descricao).HasColumnName("Descricao").HasMaxLength(240);
            builder.Property(o => o.CreatedAt).HasColumnName("Created_At");
            builder.Property(o => o.UpdatedAt).HasColumnName("Updated_At");
        }
    }
}
