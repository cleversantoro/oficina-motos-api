using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteIndicacaoConfiguration : IEntityTypeConfiguration<ClienteIndicacao>
    {
        public void Configure(EntityTypeBuilder<ClienteIndicacao> builder)
        {
            builder.ToTable("cad_clientes_indicacoes");

            builder.HasKey(i => i.Id);
            //builder.Ignore(i => i.IsDeleted);
            builder.Property(i => i.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(i => i.IndicadorNome).HasColumnName("Indicador_Nome").HasMaxLength(160).IsRequired();
            builder.Property(i => i.IndicadorTelefone).HasColumnName("Indicador_Telefone").HasMaxLength(20);
            builder.Property(i => i.Observacao).HasColumnName("Observacao").HasMaxLength(240);
            builder.Property(i => i.CreatedAt).HasColumnName("Created_At");
            builder.Property(i => i.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(i => i.Cliente)
                .WithMany(c => c.Indicacoes)
                .HasForeignKey(i => i.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
