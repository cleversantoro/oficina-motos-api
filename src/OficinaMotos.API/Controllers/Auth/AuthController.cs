using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OficinaMotos.Application.DTOs.Requests.Auth;
using OficinaMotos.Application.DTOs.Responses.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OficinaMotos.API.Controllers.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        // Usuário administrador padrão para desenvolvimento.
        // Em produção, substitua por consulta ao banco de dados com hash de senha.
        private static readonly (string Email, string Password, string Name, string Role) _adminUser =
            ("admin@oficina.com", "admin123", "Administrador", "Admin");

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Autentica o usuário e retorna um token JWT.
        /// </summary>
        [HttpPost("login")]
        [ProducesResponseType(typeof(LoginResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Login([FromBody] LoginRequestDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest(new { message = "E-mail e senha são obrigatórios." });

            // Validação de credenciais
            if (!request.Email.Equals(_adminUser.Email, StringComparison.OrdinalIgnoreCase) ||
                request.Password != _adminUser.Password)
            {
                return Unauthorized(new { message = "Credenciais inválidas." });
            }

            var jwtKey = _configuration["Jwt:Key"] ?? "chave_super_secreta_padrao_desenvolvimento_123";
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(8);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _adminUser.Email),
                new Claim(JwtRegisteredClaimNames.Email, _adminUser.Email),
                new Claim(ClaimTypes.Name, _adminUser.Name),
                new Claim(ClaimTypes.Role, _adminUser.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
            );

            return Ok(new LoginResponseDTO
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Email = _adminUser.Email,
                Name = _adminUser.Name,
                Role = _adminUser.Role,
                ExpiresAt = expiration,
            });
        }
    }
}
