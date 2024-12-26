using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Week14_3_JWT
{
    public static class JwtHelper
    {
        public static string GenerateJwtToken(string eMail, string key, string issuer, string audience, int expiryMinutes)
        {
            // Security key creation
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Signing information
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Account information (claims)
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, eMail),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Create Token
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expiryMinutes), // Expiry time
                signingCredentials: credentials);

            // Return token as string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
