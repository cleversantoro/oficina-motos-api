using System;

namespace OficinaMotos.Application.DTOs.Responses
{
    public class ClientePfResponseDTO
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public string? Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Genero { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Profissao { get; set; }
    }
}
