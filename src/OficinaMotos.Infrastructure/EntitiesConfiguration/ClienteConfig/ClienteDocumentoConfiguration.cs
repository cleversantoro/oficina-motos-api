using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteDocumentoConfiguration : IEntityTypeConfiguration<ClienteDocumento>
    {
        public void Configure(EntityTypeBuilder<ClienteDocumento> builder)
        {
            builder.ToTable("cad_clientes_documentos");

            builder.HasKey(d => d.Id);
            //builder.Ignore(d => d.IsDeleted);
            builder.Property(d => d.ClienteId).HasColumnName("Cliente_Id").IsRequired();
            builder.Property(d => d.Tipo).HasColumnName("Tipo").HasMaxLength(30).IsRequired();
            builder.Property(d => d.Documento).HasColumnName("Documento").HasMaxLength(40).IsRequired();
            builder.Property(d => d.DataEmissao).HasColumnName("Data_Emissao");
            builder.Property(d => d.DataValidade).HasColumnName("Data_Validade");
            builder.Property(d => d.OrgaoExpedidor).HasColumnName("Orgao_Expedidor").HasMaxLength(80);
            builder.Property(d => d.Principal).HasColumnName("Principal").HasColumnType("tinyint(1)");
            builder.Property(d => d.CreatedAt).HasColumnName("Created_At");
            builder.Property(d => d.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(d => d.Cliente)
                .WithMany(c => c.Documentos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
