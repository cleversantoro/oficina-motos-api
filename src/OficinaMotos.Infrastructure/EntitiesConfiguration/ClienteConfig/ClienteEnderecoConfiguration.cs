using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteEnderecoConfiguration : IEntityTypeConfiguration<ClienteEndereco>
    {
        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {
            builder.ToTable("cad_clientes_enderecos");

            builder.HasKey(e => e.Id);
            //builder.Ignore(e => e.IsDeleted);
            builder.Property(e => e.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(e => e.Tipo).HasColumnName("Tipo").IsRequired();
            builder.Property(e => e.Cep).HasColumnName("Cep").HasMaxLength(12).IsRequired();
            builder.Property(e => e.Logradouro).HasColumnName("Logradouro").HasMaxLength(160).IsRequired();
            builder.Property(e => e.Numero).HasColumnName("Numero").HasMaxLength(20).IsRequired();
            builder.Property(e => e.Bairro).HasColumnName("Bairro").HasMaxLength(120).IsRequired();
            builder.Property(e => e.Cidade).HasColumnName("Cidade").HasMaxLength(120).IsRequired();
            builder.Property(e => e.Estado).HasColumnName("Estado").HasMaxLength(60).IsRequired();
            builder.Property(e => e.Pais).HasColumnName("Pais").HasMaxLength(80);
            builder.Property(e => e.Complemento).HasColumnName("Complemento").HasMaxLength(120);
            builder.Property(e => e.Principal).HasColumnName("Principal").HasColumnType("tinyint(1)");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
