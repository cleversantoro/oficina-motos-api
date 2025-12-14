using System;

namespace OficinaMotos.Application.DTOs.Responses.Fornecedor
{
    public class FornecedorCertificacaoResponseDTO
    {
        public long Id { get; set; }
        public long FornecedorId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Instituicao { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? CodigoCertificacao { get; set; }
        public string? Escopo { get; set; }
    }
}
