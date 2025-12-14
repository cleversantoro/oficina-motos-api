using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.EstoqueConfig
{
    public class EstoqueCategoriaConfiguration : IEntityTypeConfiguration<EstoqueCategoria>
    {
        public void Configure(EntityTypeBuilder<EstoqueCategoria> builder)
        {
            builder.ToTable("est_categorias");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.Pecas)
                   .WithOne(p => p.Categoria)
                   .HasForeignKey(p => p.CategoriaId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class EstoqueFabricanteConfiguration : IEntityTypeConfiguration<EstoqueFabricante>
    {
        public void Configure(EntityTypeBuilder<EstoqueFabricante> builder)
        {
            builder.ToTable("est_fabricantes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Cnpj).HasMaxLength(32);
            builder.Property(e => e.Contato).HasMaxLength(160);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.Pecas)
                   .WithOne(p => p.Fabricante)
                   .HasForeignKey(p => p.FabricanteId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class EstoqueLocalizacaoConfiguration : IEntityTypeConfiguration<EstoqueLocalizacao>
    {
        public void Configure(EntityTypeBuilder<EstoqueLocalizacao> builder)
        {
            builder.ToTable("est_localizacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Corredor).HasMaxLength(50);
            builder.Property(e => e.Prateleira).HasMaxLength(50);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.Pecas)
                   .WithOne(p => p.Localizacao)
                   .HasForeignKey(p => p.LocalizacaoId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class EstoquePecaConfiguration : IEntityTypeConfiguration<EstoquePeca>
    {
        public void Configure(EntityTypeBuilder<EstoquePeca> builder)
        {
            builder.ToTable("est_pecas");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Codigo).HasMaxLength(80).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(240).IsRequired();
            builder.Property(e => e.Unidade).HasMaxLength(10).HasDefaultValue("UN");
            builder.Property(e => e.Status).HasMaxLength(50).HasDefaultValue("Ativo");
            builder.Property(e => e.Observacoes).HasMaxLength(500);
            builder.Property(e => e.DataCadastro).HasColumnName("Data_Cadastro");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fabricante)
                   .WithMany(f => f.Pecas)
                   .HasForeignKey(e => e.FabricanteId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Categoria)
                   .WithMany(c => c.Pecas)
                   .HasForeignKey(e => e.CategoriaId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Localizacao)
                   .WithMany(l => l.Pecas)
                   .HasForeignKey(e => e.LocalizacaoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.Anexos)
                   .WithOne(a => a.Peca)
                   .HasForeignKey(a => a.PecaId);

            builder.HasMany(e => e.Fornecedores)
                   .WithOne(f => f.Peca)
                   .HasForeignKey(f => f.PecaId);

            builder.HasMany(e => e.Movimentacoes)
                   .WithOne(m => m.Peca)
                   .HasForeignKey(m => m.PecaId);

            builder.HasMany(e => e.Historico)
                   .WithOne(h => h.Peca)
                   .HasForeignKey(h => h.PecaId);
        }
    }

    public class EstoqueMovimentacaoConfiguration : IEntityTypeConfiguration<EstoqueMovimentacao>
    {
        public void Configure(EntityTypeBuilder<EstoqueMovimentacao> builder)
        {
            builder.ToTable("est_movimentacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Referencia).HasMaxLength(120);
            builder.Property(e => e.Usuario).HasMaxLength(120);
            builder.Property(e => e.DataMovimentacao).HasColumnName("Data_Movimentacao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Peca)
                   .WithMany(p => p.Movimentacoes)
                   .HasForeignKey(e => e.PecaId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class EstoquePecaAnexoConfiguration : IEntityTypeConfiguration<EstoquePecaAnexo>
    {
        public void Configure(EntityTypeBuilder<EstoquePecaAnexo> builder)
        {
            builder.ToTable("est_pecas_anexos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(200);
            builder.Property(e => e.Tipo).HasMaxLength(100);
            builder.Property(e => e.Url).HasMaxLength(500);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataUpload).HasColumnName("Data_Upload");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Peca)
                   .WithMany(p => p.Anexos)
                   .HasForeignKey(e => e.PecaId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class EstoquePecaFornecedorConfiguration : IEntityTypeConfiguration<EstoquePecaFornecedor>
    {
        public void Configure(EntityTypeBuilder<EstoquePecaFornecedor> builder)
        {
            builder.ToTable("est_pecas_fornecedores");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Peca)
                   .WithMany(p => p.Fornecedores)
                   .HasForeignKey(e => e.PecaId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.PecasOfertadas)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class EstoquePecaHistoricoConfiguration : IEntityTypeConfiguration<EstoquePecaHistorico>
    {
        public void Configure(EntityTypeBuilder<EstoquePecaHistorico> builder)
        {
            builder.ToTable("est_pecas_historico");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Usuario).HasMaxLength(120);
            builder.Property(e => e.Campo).HasMaxLength(120);
            builder.Property(e => e.ValorAntigo).HasMaxLength(300);
            builder.Property(e => e.ValorNovo).HasMaxLength(300);
            builder.Property(e => e.DataAlteracao).HasColumnName("Data_Alteracao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Peca)
                   .WithMany(p => p.Historico)
                   .HasForeignKey(e => e.PecaId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
