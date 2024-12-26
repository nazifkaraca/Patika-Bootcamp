using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _14_1_Identity
{
    public static class Helper
    {
        public static string GenerateJwtToken(string userMail, string key, string issuer, string audience)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var credientials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Şifreli bir şekilde user Id gönderiyoruz
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userMail)
            };

            // Token oluştur
            var token = new JwtSecurityToken(issuer: issuer, audience: audience, claims: claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: credientials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
