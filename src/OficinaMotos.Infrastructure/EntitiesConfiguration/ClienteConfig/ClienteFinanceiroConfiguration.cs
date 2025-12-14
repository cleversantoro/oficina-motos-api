using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteFinanceiroConfiguration : IEntityTypeConfiguration<ClienteFinanceiro>
    {
        public void Configure(EntityTypeBuilder<ClienteFinanceiro> builder)
        {
            builder.ToTable("cad_clientes_financeiro");

            builder.HasKey(f => f.Id);
            //builder.Ignore(f => f.IsDeleted);
            builder.Property(f => f.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(f => f.LimiteCredito).HasColumnName("Limite_Credito");
            builder.Property(f => f.PrazoPagamento).HasColumnName("Prazo_Pagamento");
            builder.Property(f => f.Bloqueado).HasColumnName("Bloqueado").HasColumnType("tinyint(1)");
            builder.Property(f => f.Observacoes).HasColumnName("Observacoes").HasMaxLength(500);
            builder.Property(f => f.CreatedAt).HasColumnName("Created_At");
            builder.Property(f => f.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(f => f.Cliente)
                .WithOne(c => c.Financeiro)
                .HasForeignKey<ClienteFinanceiro>(f => f.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
