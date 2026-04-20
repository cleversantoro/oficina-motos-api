using AutoMapper;
using OficinaMotos.Application.DTOs.Requests.Auth;
using OficinaMotos.Application.DTOs.Responses.Auth;
using OficinaMotos.Application.DTOs.Responses.Seguranca;
using OficinaMotos.Application.Interfaces.Seguranca;
using OficinaMotos.Domain.Entities;
using OficinaMotos.Domain.Interfaces.Repositories.SegurancaRepo;

namespace OficinaMotos.Application.Services.Seguranca
{
    public class AuthService : IAuthService
    {
        private readonly ISegUsuarioRepository _usuarioRepository;
        private readonly ISegAuditLogRepository _auditLogRepository;
        private readonly IMapper _mapper;

        public AuthService(
            ISegUsuarioRepository usuarioRepository,
            ISegAuditLogRepository auditLogRepository,
            IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _auditLogRepository = auditLogRepository;
            _mapper = mapper;
        }

        public async Task<LoginDataResult?> LoginAsync(LoginRequestDTO request, string? ipAddress, string? userAgent)
        {
            var usuario = await _usuarioRepository.GetByEmailOrLoginAsync(request.Email);

            if (usuario == null)
            {
                await RegistrarAuditAsync(null, request.Email, "LOGIN_FAIL",
                    modulo: "Segurança",
                    descricao: $"Tentativa de login com credencial inexistente: '{request.Email}'",
                    ip: ipAddress, userAgent: userAgent);
                return null;
            }

            if (usuario.EstaBloqueado())
            {
                await RegistrarAuditAsync(usuario.Id, usuario.Login, "LOGIN_FAIL",
                    modulo: "Segurança",
                    descricao: "Tentativa de login com conta bloqueada",
                    ip: ipAddress, userAgent: userAgent);
                return null;
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, usuario.Senha))
            {
                usuario.RegistrarFalhaLogin();
                await _usuarioRepository.UpdateAsync(usuario);

                await RegistrarAuditAsync(usuario.Id, usuario.Login, "LOGIN_FAIL",
                    modulo: "Segurança",
                    descricao: $"Senha incorreta. Tentativas: {usuario.TentativasLogin}",
                    ip: ipAddress, userAgent: userAgent);
                return null;
            }

            if (usuario.Status != 1)
            {
                await RegistrarAuditAsync(usuario.Id, usuario.Login, "LOGIN_FAIL",
                    modulo: "Segurança",
                    descricao: $"Tentativa de login com conta inativa/suspensa (Status={usuario.Status})",
                    ip: ipAddress, userAgent: userAgent);
                return null;
            }

            usuario.RegistrarLoginSucesso();
            await _usuarioRepository.UpdateAsync(usuario);

            var usuarioComPerfis = await _usuarioRepository.GetWithPerfisAsync(usuario.Id);

            var perfis = usuarioComPerfis?.UsuariosPerfis
                .Where(up => up.Ativo && up.Perfil != null)
                .Select(up => up.Perfil!.Nome)
                .ToList() ?? new List<string>();

            var permissoes = usuarioComPerfis?.UsuariosPerfis
                .Where(up => up.Ativo && up.Perfil?.PerfisPermissoes != null)
                .SelectMany(up => up.Perfil!.PerfisPermissoes)
                .Where(pp => pp.Permissao?.Modulo != null)
                .Select(pp => $"{pp.Permissao!.Modulo!.Nome}:{pp.Permissao.Acao}")
                .Distinct()
                .ToList() ?? new List<string>();

            await RegistrarAuditAsync(usuario.Id, usuario.Login, "LOGIN",
                modulo: "Segurança",
                descricao: "Login realizado com sucesso",
                ip: ipAddress, userAgent: userAgent);

            return new LoginDataResult
            {
                UserId = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Login = usuario.Login,
                Roles = perfis,
                Permissions = permissoes,
            };
        }

        public async Task<SegAuditLogResponseDTO> RegistrarAuditAsync(
            long? usuarioId, string? login, string acao,
            string? modulo = null, string? tabela = null, string? registroId = null,
            string? descricao = null, string? dadosAntes = null, string? dadosDepois = null,
            string? ip = null, string? userAgent = null)
        {
            var log = new SegAuditLog
            {
                UsuarioId = usuarioId,
                Login = login,
                Acao = acao,
                Modulo = modulo,
                Tabela = tabela,
                RegistroId = registroId,
                Descricao = descricao,
                DadosAntes = dadosAntes,
                DadosDepois = dadosDepois,
                Ip = ip,
                UserAgent = userAgent,
            };

            var created = await _auditLogRepository.AddAsync(log);
            return _mapper.Map<SegAuditLogResponseDTO>(created);
        }
    }
}
