using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.ClienteConfig
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cad_clientes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Codigo).HasColumnName("Codigo");
            builder.Property(c => c.Nome).HasColumnName("Nome").HasMaxLength(160).IsRequired();
            builder.Property(c => c.NomeExibicao).HasColumnName("NomeExibicao").HasMaxLength(160).IsRequired();
            builder.Property(c => c.Documento).HasColumnName("Documento").HasMaxLength(20).IsRequired();
            builder.Property(c => c.Tipo).HasColumnName("Tipo").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.Vip).HasColumnName("Vip").HasColumnType("tinyint(1)").IsRequired();
            builder.Property(c => c.Observacoes).HasColumnName("Observacoes").HasMaxLength(500);
            builder.Property(c => c.OrigemCadastroId).HasColumnName("OrigemCadastroId");
            builder.Property(c => c.Telefone).HasColumnName("Telefone").HasMaxLength(20);
            builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(160);
            builder.Property(c => c.OrigemId).HasColumnName("Origem_Id");


            builder.HasOne(c => c.Origem).WithMany(o => o.Clientes).HasForeignKey(c => c.OrigemId).OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(c => c.Anexos).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.Contatos).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.Documentos).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.Enderecos).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.Indicacoes).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.ConsentimentosLgpd).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);

            builder.HasMany(c => c.Veiculos).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            builder.HasMany(c => c.OrdensServico).WithOne(a => a.Cliente).HasForeignKey(a => a.ClienteId);
            
            builder.HasOne(c => c.PessoaFisica).WithOne(pf => pf.Cliente).HasForeignKey<ClientePf>(pf => pf.ClienteId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(c => c.PessoaJuridica).WithOne(pj => pj.Cliente).HasForeignKey<ClientePj>(pj => pj.ClienteId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(c => c.Financeiro).WithOne(f => f.Cliente).HasForeignKey<ClienteFinanceiro>(f => f.ClienteId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(c => c.CreatedAt).HasColumnName("Created_At");
            builder.Property(c => c.UpdatedAt).HasColumnName("Updated_At");
        }
    }
}
