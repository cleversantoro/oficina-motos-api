using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.FinanceiroConfig
{
    public class FinanceiroMetodoPagamentoConfiguration : IEntityTypeConfiguration<FinanceiroMetodoPagamento>
    {
        public void Configure(EntityTypeBuilder<FinanceiroMetodoPagamento> builder)
        {
            builder.ToTable("fin_metodos_pagamento");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.Pagamentos)
                   .WithOne(p => p.Metodo)
                   .HasForeignKey(p => p.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.ContasPagar)
                   .WithOne(p => p.Metodo)
                   .HasForeignKey(p => p.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.ContasReceber)
                   .WithOne(r => r.Metodo)
                   .HasForeignKey(r => r.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class FinanceiroPagamentoConfiguration : IEntityTypeConfiguration<FinanceiroPagamento>
    {
        public void Configure(EntityTypeBuilder<FinanceiroPagamento> builder)
        {
            builder.ToTable("fin_pagamentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Status).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataPagamento).HasColumnName("Data_Pagamento");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Cliente)
                   .WithMany()
                   .HasForeignKey(e => e.ClienteId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Pagamentos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.OrdemServico)
                   .WithMany(o => o.PagamentosFinanceiros)
                   .HasForeignKey(e => e.OrdemServicoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Metodo)
                   .WithMany(m => m.Pagamentos)
                   .HasForeignKey(e => e.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.Anexos)
                   .WithOne(a => a.Pagamento)
                   .HasForeignKey(a => a.PagamentoId);
        }
    }

    public class FinanceiroAnexoConfiguration : IEntityTypeConfiguration<FinanceiroAnexo>
    {
        public void Configure(EntityTypeBuilder<FinanceiroAnexo> builder)
        {
            builder.ToTable("fin_anexos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(200);
            builder.Property(e => e.Tipo).HasMaxLength(100);
            builder.Property(e => e.Url).HasMaxLength(500);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataUpload).HasColumnName("Data_Upload");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Pagamento)
                   .WithMany(p => p.Anexos)
                   .HasForeignKey(e => e.PagamentoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.ContaPagar)
                   .WithMany(c => c.Anexos)
                   .HasForeignKey(e => e.ContaPagarId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.ContaReceber)
                   .WithMany(c => c.Anexos)
                   .HasForeignKey(e => e.ContaReceberId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }

    public class FinanceiroContaPagarConfiguration : IEntityTypeConfiguration<FinanceiroContaPagar>
    {
        public void Configure(EntityTypeBuilder<FinanceiroContaPagar> builder)
        {
            builder.ToTable("fin_contas_pagar");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao).HasMaxLength(240).IsRequired();
            builder.Property(e => e.Status).HasMaxLength(50).IsRequired();
            builder.Property(e => e.DataPagamento).HasColumnName("Data_Pagamento");
            builder.Property(e => e.Vencimento).HasColumnName("Vencimento");
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.ContasAPagar)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Metodo)
                   .WithMany(m => m.ContasPagar)
                   .HasForeignKey(e => e.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.Anexos)
                   .WithOne(a => a.ContaPagar)
                   .HasForeignKey(a => a.ContaPagarId);
        }
    }

    public class FinanceiroContaReceberConfiguration : IEntityTypeConfiguration<FinanceiroContaReceber>
    {
        public void Configure(EntityTypeBuilder<FinanceiroContaReceber> builder)
        {
            builder.ToTable("fin_contas_receber");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao).HasMaxLength(240).IsRequired();
            builder.Property(e => e.Status).HasMaxLength(50).IsRequired();
            builder.Property(e => e.DataRecebimento).HasColumnName("Data_Recebimento");
            builder.Property(e => e.Vencimento).HasColumnName("Vencimento");
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Cliente)
                   .WithMany()
                   .HasForeignKey(e => e.ClienteId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Metodo)
                   .WithMany(m => m.ContasReceber)
                   .HasForeignKey(e => e.MetodoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.Anexos)
                   .WithOne(a => a.ContaReceber)
                   .HasForeignKey(a => a.ContaReceberId);
        }
    }

    public class FinanceiroHistoricoConfiguration : IEntityTypeConfiguration<FinanceiroHistorico>
    {
        public void Configure(EntityTypeBuilder<FinanceiroHistorico> builder)
        {
            builder.ToTable("fin_historico");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Entidade).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Usuario).HasMaxLength(120);
            builder.Property(e => e.Campo).HasMaxLength(120);
            builder.Property(e => e.ValorAntigo).HasMaxLength(300);
            builder.Property(e => e.ValorNovo).HasMaxLength(300);
            builder.Property(e => e.DataAlteracao).HasColumnName("Data_Alteracao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }

    public class FinanceiroLancamentoConfiguration : IEntityTypeConfiguration<FinanceiroLancamento>
    {
        public void Configure(EntityTypeBuilder<FinanceiroLancamento> builder)
        {
            builder.ToTable("fin_lancamentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(240).IsRequired();
            builder.Property(e => e.Referencia).HasMaxLength(120);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.DataLancamento).HasColumnName("Data_Lancamento");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");
        }
    }
}
