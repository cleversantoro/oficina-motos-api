using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClientePjConfiguration : IEntityTypeConfiguration<ClientePj>
    {
        public void Configure(EntityTypeBuilder<ClientePj> builder)
        {
            builder.ToTable("cad_clientes_pj");

            builder.HasKey(p => p.Id);
            //builder.Ignore(p => p.IsDeleted);
            builder.Property(p => p.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(p => p.Cnpj).HasColumnName("Cnpj").HasMaxLength(20).IsRequired();
            builder.Property(p => p.RazaoSocial).HasColumnName("Razao_Social").HasMaxLength(180).IsRequired();
            builder.Property(p => p.NomeFantasia).HasColumnName("Nome_Fantasia").HasMaxLength(180);
            builder.Property(p => p.InscricaoEstadual).HasColumnName("Inscricao_Estadual").HasMaxLength(30);
            builder.Property(p => p.InscricaoMunicipal).HasColumnName("Inscricao_Municipal").HasMaxLength(30);
            builder.Property(p => p.Responsavel).HasColumnName("Responsavel").HasMaxLength(120);
            builder.Property(p => p.CreatedAt).HasColumnName("Created_At");
            builder.Property(p => p.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(p => p.Cliente)
                .WithOne(c => c.PessoaJuridica)
                .HasForeignKey<ClientePj>(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
