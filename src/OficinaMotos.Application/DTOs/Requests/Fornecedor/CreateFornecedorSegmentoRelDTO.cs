namespace OficinaMotos.Application.DTOs.Requests.Fornecedor
{
    public class CreateFornecedorSegmentoRelDTO
    {
        public long FornecedorId { get; set; }
        public long SegmentoId { get; set; }
        public bool Principal { get; set; }
        public string? Observacoes { get; set; }
    }
}
