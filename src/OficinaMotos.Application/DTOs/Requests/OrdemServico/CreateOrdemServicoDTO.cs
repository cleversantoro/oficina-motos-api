using System;

namespace OficinaMotos.Application.DTOs.Requests.OrdemServico
{
    public class CreateOrdemServicoDTO
    {
        public long ClienteId { get; set; }
        public long MecanicoId { get; set; }
        public string DescricaoProblema { get; set; } = string.Empty;
        public string Status { get; set; } = "ABERTA";
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
