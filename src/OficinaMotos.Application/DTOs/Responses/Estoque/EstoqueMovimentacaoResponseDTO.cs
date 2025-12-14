using System;

namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoqueMovimentacaoResponseDTO
    {
        public long Id { get; set; }
        public long PecaId { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string? Referencia { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string? Usuario { get; set; }
    }
}
