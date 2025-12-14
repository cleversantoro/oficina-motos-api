using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteLgpdConsentimentoConfiguration : IEntityTypeConfiguration<ClienteLgpdConsentimento>
    {
        public void Configure(EntityTypeBuilder<ClienteLgpdConsentimento> builder)
        {
            builder.ToTable("cad_clientes_lgpd_consentimentos");

            builder.HasKey(c => c.Id);
            //builder.Ignore(c => c.IsDeleted);
            builder.Property(c => c.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(c => c.Tipo).HasColumnName("Tipo").IsRequired();
            builder.Property(c => c.Aceito).HasColumnName("Aceito").HasColumnType("tinyint(1)").IsRequired();
            builder.Property(c => c.Data).HasColumnName("Data");
            builder.Property(c => c.ValidoAte).HasColumnName("Valido_Ate");
            builder.Property(c => c.Observacoes).HasColumnName("Observacoes").HasMaxLength(240);
            builder.Property(c => c.Canal).HasColumnName("Canal").HasMaxLength(80).IsRequired();
            builder.Property(c => c.CreatedAt).HasColumnName("Created_At");
            builder.Property(c => c.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(c => c.Cliente)
                .WithMany(cl => cl.ConsentimentosLgpd)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
