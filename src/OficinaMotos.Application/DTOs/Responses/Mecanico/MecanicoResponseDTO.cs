using System;
using System.Collections.Generic;

namespace OficinaMotos.Application.DTOs.Responses.Mecanico
{
    public class MecanicoResponseDTO
    {
        public long Id { get; set; }
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

        public ICollection<MecanicoCertificacaoResponseDTO> Certificacoes { get; set; } = new List<MecanicoCertificacaoResponseDTO>();
        public ICollection<MecanicoContatoResponseDTO> Contatos { get; set; } = new List<MecanicoContatoResponseDTO>();
        public ICollection<MecanicoDisponibilidadeResponseDTO> Disponibilidades { get; set; } = new List<MecanicoDisponibilidadeResponseDTO>();
        public ICollection<MecanicoDocumentoResponseDTO> Documentos { get; set; } = new List<MecanicoDocumentoResponseDTO>();
        public ICollection<MecanicoEnderecoResponseDTO> Enderecos { get; set; } = new List<MecanicoEnderecoResponseDTO>();
        public ICollection<MecanicoEspecialidadeRelResponseDTO> Especialidades { get; set; } = new List<MecanicoEspecialidadeRelResponseDTO>();
        public ICollection<MecanicoExperienciaResponseDTO> Experiencias { get; set; } = new List<MecanicoExperienciaResponseDTO>();
    }
}
