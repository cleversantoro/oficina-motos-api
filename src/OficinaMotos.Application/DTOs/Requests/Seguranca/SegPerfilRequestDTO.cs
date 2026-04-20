namespace OficinaMotos.Application.DTOs.Requests.Seguranca
{
    public class CreateSegPerfilDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Nivel { get; set; } = 99;
    }

    public class UpdateSegPerfilDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Nivel { get; set; }
        public int Status { get; set; }
    }

    public class SetPerfilPermissoesDTO
    {
        /// <summary>IDs das permissões que o perfil deve ter. Substitui a lista atual.</summary>
        public List<long> PermissaoIds { get; set; } = new();
    }
}
