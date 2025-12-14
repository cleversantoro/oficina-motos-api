using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.OrdemServicoConfig
{
    public class OrdemServicoConfiguration : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("ordens_servico");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DescricaoProblema).HasMaxLength(500).IsRequired();
            builder.Property(e => e.Status).HasMaxLength(50).HasDefaultValue("ABERTA");
            builder.Property(e => e.DataAbertura).HasColumnName("Data_Abertura");
            builder.Property(e => e.DataConclusao).HasColumnName("Data_Conclusao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Cliente)
                   .WithMany(c => c.OrdensServico)
                   .HasForeignKey(e => e.ClienteId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Mecanico)
                   .WithMany(m => m.OrdensServico)
                   .HasForeignKey(e => e.MecanicoId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Anexos)
                   .WithOne(a => a.OrdemServico)
                   .HasForeignKey(a => a.OrdemServicoId);

            builder.HasMany(e => e.Avaliacoes)
                   .WithOne(a => a.OrdemServico)
                   .HasForeignKey(a => a.OrdemServicoId);

            builder.HasMany(e => e.Checklists)
                   .WithOne(c => c.OrdemServico)
                   .HasForeignKey(c => c.OrdemServicoId);

            builder.HasMany(e => e.Itens)
                   .WithOne(i => i.OrdemServico)
                   .HasForeignKey(i => i.OrdemServicoId);

            builder.HasMany(e => e.Observacoes)
                   .WithOne(o => o.OrdemServico)
                   .HasForeignKey(o => o.OrdemServicoId);

            builder.HasMany(e => e.Historico)
                   .WithOne(h => h.OrdemServico)
                   .HasForeignKey(h => h.OrdemServicoId);

            builder.HasMany(e => e.Pagamentos)
                   .WithOne(p => p.OrdemServico)
                   .HasForeignKey(p => p.OrdemServicoId);
        }
    }

    public class OrdemServicoAnexoConfiguration : IEntityTypeConfiguration<OrdemServicoAnexo>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoAnexo> builder)
        {
            builder.ToTable("ordens_servico_anexos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(200);
            builder.Property(e => e.Tipo).HasMaxLength(100);
            builder.Property(e => e.Url).HasMaxLength(500);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataUpload).HasColumnName("Data_Upload");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class OrdemServicoAvaliacaoConfiguration : IEntityTypeConfiguration<OrdemServicoAvaliacao>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoAvaliacao> builder)
        {
            builder.ToTable("ordens_servico_avaliacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Comentario).HasMaxLength(500);
            builder.Property(e => e.Usuario).HasMaxLength(160);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class OrdemServicoChecklistConfiguration : IEntityTypeConfiguration<OrdemServicoChecklist>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoChecklist> builder)
        {
            builder.ToTable("ordens_servico_checklists");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Item).HasMaxLength(240).IsRequired();
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class OrdemServicoItemConfiguration : IEntityTypeConfiguration<OrdemServicoItem>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoItem> builder)
        {
            builder.ToTable("ordens_servico_itens");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao).HasMaxLength(240).IsRequired();
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Peca)
                   .WithMany(p => p.OrdemServicoItens)
                   .HasForeignKey(e => e.PecaId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class OrdemServicoObservacaoConfiguration : IEntityTypeConfiguration<OrdemServicoObservacao>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoObservacao> builder)
        {
            builder.ToTable("ordens_servico_observacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Usuario).HasMaxLength(160);
            builder.Property(e => e.Texto).HasMaxLength(500).IsRequired();
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class OrdemServicoHistoricoConfiguration : IEntityTypeConfiguration<OrdemServicoHistorico>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoHistorico> builder)
        {
            builder.ToTable("ordens_servico_historico");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Usuario).HasMaxLength(160);
            builder.Property(e => e.Campo).HasMaxLength(120);
            builder.Property(e => e.ValorAntigo).HasMaxLength(300);
            builder.Property(e => e.ValorNovo).HasMaxLength(300);
            builder.Property(e => e.DataAlteracao).HasColumnName("Data_Alteracao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class OrdemServicoPagamentoConfiguration : IEntityTypeConfiguration<OrdemServicoPagamento>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoPagamento> builder)
        {
            builder.ToTable("ordens_servico_pagamentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Status).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Metodo).HasMaxLength(120);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataPagamento).HasColumnName("Data_Pagamento");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }
}
