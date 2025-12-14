using System;

namespace OficinaMotos.Application.DTOs.Requests.Mecanico
{
    public class UpdateMecanicoDTO
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string? Sobrenome { get; set; }
        public string? NomeSocial { get; set; }
        public string DocumentoPrincipal { get; set; } = string.Empty;
        public int TipoDocumento { get; set; } = 1;
        public DateTime? DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string Status { get; set; } = "Ativo";
        public long? EspecialidadePrincipalId { get; set; }
        public string Nivel { get; set; } = "Pleno";
        public decimal ValorHora { get; set; }
        public int CargaHorariaSemanal { get; set; } = 44;
        public string? Observacoes { get; set; }
    }
}
