using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMotos.Domain.Entities;

namespace OficinaMotos.Infrastructure.EntitiesConfiguration.FornecedorConfig
{
    public class FornecedorSegmentoConfiguration : IEntityTypeConfiguration<FornecedorSegmento>
    {
        public void Configure(EntityTypeBuilder<FornecedorSegmento> builder)
        {
            builder.ToTable("fornecedor_segmentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Codigo).HasMaxLength(40).IsRequired();
            builder.Property(e => e.Nome).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.FornecedoresPrincipais)
                   .WithOne(f => f.SegmentoPrincipal)
                   .HasForeignKey(f => f.SegmentoPrincipalId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(e => e.FornecedorSegmentos)
                   .WithOne(rel => rel.Segmento)
                   .HasForeignKey(rel => rel.SegmentoId);
        }
    }

    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("fornecedores");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Codigo).HasMaxLength(40).IsRequired();
            builder.Property(e => e.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.RazaoSocial).HasMaxLength(200).IsRequired();
            builder.Property(e => e.NomeFantasia).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Documento).HasMaxLength(32).IsRequired();
            builder.Property(e => e.InscricaoEstadual).HasMaxLength(50);
            builder.Property(e => e.InscricaoMunicipal).HasMaxLength(50);
            builder.Property(e => e.Website).HasMaxLength(200);
            builder.Property(e => e.Email).HasMaxLength(160);
            builder.Property(e => e.TelefonePrincipal).HasMaxLength(40);
            builder.Property(e => e.Status).HasMaxLength(50).HasDefaultValue("ATIVO");
            builder.Property(e => e.CondicaoPagamentoPadrao).HasMaxLength(120);
            builder.Property(e => e.Observacoes).HasMaxLength(500);
            builder.Property(e => e.PrazoGarantiaPadrao).HasMaxLength(120);
            builder.Property(e => e.TermosNegociados).HasMaxLength(500);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasMany(e => e.Segmentos)
                   .WithOne(rel => rel.Fornecedor)
                   .HasForeignKey(rel => rel.FornecedorId);

            builder.HasMany(e => e.Enderecos)
                   .WithOne(end => end.Fornecedor)
                   .HasForeignKey(end => end.FornecedorId);

            builder.HasMany(e => e.Contatos)
                   .WithOne(c => c.Fornecedor)
                   .HasForeignKey(c => c.FornecedorId);

            builder.HasMany(e => e.Representantes)
                   .WithOne(r => r.Fornecedor)
                   .HasForeignKey(r => r.FornecedorId);

            builder.HasMany(e => e.Bancos)
                   .WithOne(b => b.Fornecedor)
                   .HasForeignKey(b => b.FornecedorId);

            builder.HasMany(e => e.Documentos)
                   .WithOne(d => d.Fornecedor)
                   .HasForeignKey(d => d.FornecedorId);

            builder.HasMany(e => e.Certificacoes)
                   .WithOne(c => c.Fornecedor)
                   .HasForeignKey(c => c.FornecedorId);

            builder.HasMany(e => e.Avaliacoes)
                   .WithOne(a => a.Fornecedor)
                   .HasForeignKey(a => a.FornecedorId);
        }
    }

    public class FornecedorSegmentoRelConfiguration : IEntityTypeConfiguration<FornecedorSegmentoRel>
    {
        public void Configure(EntityTypeBuilder<FornecedorSegmentoRel> builder)
        {
            builder.ToTable("fornecedor_segmentos_rel");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Observacoes).HasMaxLength(300);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Segmentos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Segmento)
                   .WithMany(s => s.FornecedorSegmentos)
                   .HasForeignKey(e => e.SegmentoId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorEnderecoConfiguration : IEntityTypeConfiguration<FornecedorEndereco>
    {
        public void Configure(EntityTypeBuilder<FornecedorEndereco> builder)
        {
            builder.ToTable("fornecedor_enderecos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Cep).HasMaxLength(20);
            builder.Property(e => e.Logradouro).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Numero).HasMaxLength(20).IsRequired();
            builder.Property(e => e.Bairro).HasMaxLength(120).IsRequired();
            builder.Property(e => e.Cidade).HasMaxLength(120).IsRequired();
            builder.Property(e => e.Estado).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Pais).HasMaxLength(80);
            builder.Property(e => e.Complemento).HasMaxLength(120);
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Enderecos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorContatoConfiguration : IEntityTypeConfiguration<FornecedorContato>
    {
        public void Configure(EntityTypeBuilder<FornecedorContato> builder)
        {
            builder.ToTable("fornecedor_contatos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Valor).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Observacao).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Contatos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorRepresentanteConfiguration : IEntityTypeConfiguration<FornecedorRepresentante>
    {
        public void Configure(EntityTypeBuilder<FornecedorRepresentante> builder)
        {
            builder.ToTable("fornecedor_representantes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Cargo).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(160);
            builder.Property(e => e.Telefone).HasMaxLength(40);
            builder.Property(e => e.Celular).HasMaxLength(40);
            builder.Property(e => e.PreferenciaContato).HasMaxLength(60);
            builder.Property(e => e.Observacoes).HasMaxLength(500);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Representantes)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorBancoConfiguration : IEntityTypeConfiguration<FornecedorBanco>
    {
        public void Configure(EntityTypeBuilder<FornecedorBanco> builder)
        {
            builder.ToTable("fornecedor_bancos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Banco).HasMaxLength(120).IsRequired();
            builder.Property(e => e.Agencia).HasMaxLength(30);
            builder.Property(e => e.Conta).HasMaxLength(30);
            builder.Property(e => e.Digito).HasMaxLength(5);
            builder.Property(e => e.TipoConta).HasMaxLength(50);
            builder.Property(e => e.PixChave).HasMaxLength(160);
            builder.Property(e => e.Observacoes).HasMaxLength(240);
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Bancos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorDocumentoConfiguration : IEntityTypeConfiguration<FornecedorDocumento>
    {
        public void Configure(EntityTypeBuilder<FornecedorDocumento> builder)
        {
            builder.ToTable("fornecedor_documentos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Numero).HasMaxLength(120).IsRequired();
            builder.Property(e => e.OrgaoExpedidor).HasMaxLength(120);
            builder.Property(e => e.ArquivoUrl).HasMaxLength(500);
            builder.Property(e => e.Observacoes).HasMaxLength(240);
            builder.Property(e => e.DataEmissao).HasColumnName("Data_Emissao");
            builder.Property(e => e.DataValidade).HasColumnName("Data_Validade");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Documentos)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorCertificacaoConfiguration : IEntityTypeConfiguration<FornecedorCertificacao>
    {
        public void Configure(EntityTypeBuilder<FornecedorCertificacao> builder)
        {
            builder.ToTable("fornecedor_certificacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Titulo).HasMaxLength(160).IsRequired();
            builder.Property(e => e.Instituicao).HasMaxLength(160);
            builder.Property(e => e.CodigoCertificacao).HasMaxLength(120);
            builder.Property(e => e.Escopo).HasMaxLength(240);
            builder.Property(e => e.DataEmissao).HasColumnName("Data_Emissao");
            builder.Property(e => e.DataValidade).HasColumnName("Data_Validade");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Certificacoes)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FornecedorAvaliacaoConfiguration : IEntityTypeConfiguration<FornecedorAvaliacao>
    {
        public void Configure(EntityTypeBuilder<FornecedorAvaliacao> builder)
        {
            builder.ToTable("fornecedor_avaliacoes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.AvaliadoPor).HasMaxLength(160);
            builder.Property(e => e.Categoria).HasMaxLength(100);
            builder.Property(e => e.Comentarios).HasMaxLength(500);
            builder.Property(e => e.DataAvaliacao).HasColumnName("Data_Avaliacao");
            builder.Property(e => e.CreatedAt).HasColumnName("Created_At");
            builder.Property(e => e.UpdatedAt).HasColumnName("Updated_At");

            builder.HasOne(e => e.Fornecedor)
                   .WithMany(f => f.Avaliacoes)
                   .HasForeignKey(e => e.FornecedorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
