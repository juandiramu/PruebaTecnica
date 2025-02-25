using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using School.Domain.Shared;
using System.Threading.Tasks;

namespace School.Infrastructure.Shared
{
	public class Token : IToken
	{
		private const string SecretKey = "TuClaveSecretaMuySeguraYConMasDe32Caracteres1234"; 
		private const string Issuer = "TuIssuer";
		private const string Audience = "TuAudience";
		private const int ExpirationMinutes = 60;

		public Task<string> GenerateAsync(Guid userId, string username, string role)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
				new Claim(JwtRegisteredClaimNames.UniqueName, username),
				new Claim(ClaimTypes.Role, role),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			var token = new JwtSecurityToken(
				issuer: Issuer,
				audience: Audience,
				claims: claims,
				expires: DateTime.UtcNow.AddMinutes(ExpirationMinutes),
				signingCredentials: credentials
			);

			return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
		}
	}
}
