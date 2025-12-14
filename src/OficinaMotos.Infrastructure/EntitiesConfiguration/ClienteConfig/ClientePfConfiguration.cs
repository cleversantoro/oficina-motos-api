using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClientePfConfiguration : IEntityTypeConfiguration<ClientePf>
    {
        public void Configure(EntityTypeBuilder<ClientePf> builder)
        {
            builder.ToTable("cad_clientes_pf");

            builder.HasKey(p => p.Id);
            //builder.Ignore(p => p.IsDeleted);
            builder.Property(p => p.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(p => p.Cpf).HasColumnName("Cpf").HasMaxLength(14).IsRequired();
            builder.Property(p => p.Rg).HasColumnName("Rg").HasMaxLength(20);
            builder.Property(p => p.DataNascimento).HasColumnName("Data_Nascimento");
            builder.Property(p => p.Genero).HasColumnName("Genero").HasMaxLength(30);
            builder.Property(p => p.EstadoCivil).HasColumnName("Estado_Civil").HasMaxLength(20);
            builder.Property(p => p.Profissao).HasColumnName("Profissao").HasMaxLength(120);
            builder.Property(p => p.CreatedAt).HasColumnName("Created_At");
            builder.Property(p => p.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(p => p.Cliente)
                .WithOne(c => c.PessoaFisica)
                .HasForeignKey<ClientePf>(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
