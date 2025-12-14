using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteContatoConfiguration : IEntityTypeConfiguration<ClienteContato>
    {
        public void Configure(EntityTypeBuilder<ClienteContato> builder)
        {
            builder.ToTable("cad_clientes_contatos");

            builder.HasKey(c => c.Id);
            //builder.Ignore(c => c.IsDeleted);
            builder.Property(c => c.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(c => c.Tipo).HasColumnName("Tipo").IsRequired();
            builder.Property(c => c.Valor).HasColumnName("Valor").HasMaxLength(160).IsRequired();
            builder.Property(c => c.Principal).HasColumnName("Principal").HasColumnType("tinyint(1)");
            builder.Property(c => c.Observacao).HasColumnName("Observacao").HasMaxLength(240);
            builder.Property(c => c.CreatedAt).HasColumnName("Created_At");
            builder.Property(c => c.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(c => c.Cliente)
                .WithMany(cl => cl.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
