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

            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(160).IsRequired();
            builder.Property(e => e.Descricao).HasColumnName("descricao").HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

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

            builder.Property(e => e.OrdemServicoId).HasColumnName("ordem_servico_id");
            builder.Property(e => e.ClienteId).HasColumnName("cliente_id");
            builder.Property(e => e.FornecedorId).HasColumnName("fornecedor_id");
            builder.Property(e => e.Valor).HasColumnName("valor").HasPrecision(18, 2).IsRequired();
            builder.Property(e => e.Status).HasColumnName("status").HasMaxLength(50).IsRequired();
            builder.Property(e => e.DataPagamento).HasColumnName("data_pagamento");
            builder.Property(e => e.MetodoId).HasColumnName("metodo_id");
            builder.Property(e => e.Observacao).HasColumnName("observacao").HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

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

            builder.Property(e => e.PagamentoId).HasColumnName("pagamento_id");
            builder.Property(e => e.ContaPagarId).HasColumnName("conta_pagar_id");
            builder.Property(e => e.ContaReceberId).HasColumnName("conta_receber_id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(200);
            builder.Property(e => e.Tipo).HasColumnName("tipo").HasMaxLength(100);
            builder.Property(e => e.Url).HasColumnName("url").HasMaxLength(500);
            builder.Property(e => e.Observacao).HasColumnName("observacao").HasMaxLength(240);
            builder.Property(e => e.DataUpload).HasColumnName("data_upload");
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

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

            builder.Property(e => e.FornecedorId).HasColumnName("fornecedor_id");
            builder.Property(e => e.Descricao).HasColumnName("descricao").HasMaxLength(240).IsRequired();
            builder.Property(e => e.Valor).HasColumnName("valor").HasPrecision(18, 2).IsRequired();
            builder.Property(e => e.Vencimento).HasColumnName("vencimento").IsRequired();
            builder.Property(e => e.Status).HasColumnName("status").HasMaxLength(50).IsRequired();
            builder.Property(e => e.DataPagamento).HasColumnName("data_pagamento");
            builder.Property(e => e.MetodoId).HasColumnName("metodo_id");
            builder.Property(e => e.Observacao).HasColumnName("observacao").HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

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

            builder.Property(e => e.ClienteId).HasColumnName("cliente_id");
            builder.Property(e => e.Descricao).HasColumnName("descricao").HasMaxLength(240).IsRequired();
            builder.Property(e => e.Valor).HasColumnName("valor").HasPrecision(18, 2).IsRequired();
            builder.Property(e => e.Vencimento).HasColumnName("vencimento").IsRequired();
            builder.Property(e => e.Status).HasColumnName("status").HasMaxLength(50).IsRequired();
            builder.Property(e => e.DataRecebimento).HasColumnName("data_recebimento");
            builder.Property(e => e.MetodoId).HasColumnName("metodo_id");
            builder.Property(e => e.Observacao).HasColumnName("observacao").HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");

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

            builder.Property(e => e.Entidade).HasColumnName("entidade").HasMaxLength(100).IsRequired();
            builder.Property(e => e.EntidadeId).HasColumnName("entidade_id").IsRequired();
            builder.Property(e => e.DataAlteracao).HasColumnName("data_alteracao").IsRequired();
            builder.Property(e => e.Usuario).HasColumnName("usuario").HasMaxLength(120);
            builder.Property(e => e.Campo).HasColumnName("campo").HasMaxLength(120);
            builder.Property(e => e.ValorAntigo).HasColumnName("valor_antigo").HasMaxLength(300);
            builder.Property(e => e.ValorNovo).HasColumnName("valor_novo").HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        }
    }

    public class FinanceiroLancamentoConfiguration : IEntityTypeConfiguration<FinanceiroLancamento>
    {
        public void Configure(EntityTypeBuilder<FinanceiroLancamento> builder)
        {
            builder.ToTable("fin_lancamentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasColumnName("tipo").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Descricao).HasColumnName("descricao").HasMaxLength(240).IsRequired();
            builder.Property(e => e.Valor).HasColumnName("valor").HasPrecision(18, 2).IsRequired();
            builder.Property(e => e.DataLancamento).HasColumnName("data_lancamento").IsRequired();
            builder.Property(e => e.Referencia).HasColumnName("referencia").HasMaxLength(120);
            builder.Property(e => e.Observacao).HasColumnName("observacao").HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("created_at");
            builder.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        }
    }
}
