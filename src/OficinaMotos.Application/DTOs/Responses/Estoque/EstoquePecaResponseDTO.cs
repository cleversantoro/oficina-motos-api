namespace OficinaMotos.Application.DTOs.Responses.Estoque
{
    public class EstoquePecaResponseDTO
    {
        public long Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public long? FabricanteId { get; set; }
        public long? CategoriaId { get; set; }
        public long? LocalizacaoId { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public string Unidade { get; set; } = "UN";
        public string Status { get; set; } = "Ativo";
        public string? Observacoes { get; set; }
    }
}
