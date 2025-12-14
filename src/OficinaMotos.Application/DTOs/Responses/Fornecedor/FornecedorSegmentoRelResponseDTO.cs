namespace OficinaMotos.Application.DTOs.Responses.Fornecedor
{
    public class FornecedorSegmentoRelResponseDTO
    {
        public long Id { get; set; }
        public long FornecedorId { get; set; }
        public long SegmentoId { get; set; }
        public bool Principal { get; set; }
        public string? Observacoes { get; set; }
    }
}
