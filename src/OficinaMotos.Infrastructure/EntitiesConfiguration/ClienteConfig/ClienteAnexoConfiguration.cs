using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteAnexoConfiguration : IEntityTypeConfiguration<ClienteAnexo>
    {
        public void Configure(EntityTypeBuilder<ClienteAnexo> builder)
        {
            builder.ToTable("cad_clientes_anexos");

            builder.HasKey(a => a.Id);
            //builder.Ignore(a => a.IsDeleted);
            builder.Property(a => a.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(a => a.Nome).HasColumnName("Nome").HasMaxLength(200).IsRequired();
            builder.Property(a => a.Tipo).HasColumnName("Tipo").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Url).HasColumnName("Url").HasMaxLength(500).IsRequired();
            builder.Property(a => a.Observacao).HasColumnName("Observacao").HasMaxLength(240);
            builder.Property(a => a.CreatedAt).HasColumnName("Created_At");
            builder.Property(a => a.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(a => a.Cliente)
                .WithMany(c => c.Anexos)
                .HasForeignKey(a => a.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
