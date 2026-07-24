using System.Text;
using System.Security.Claims;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;

namespace Business_Layer.Services
{
    public class JwtService : IJwtService
    {

        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration) => _configuration = configuration;

        public string GenerateAccessToken(User user)
        {

            var claims = new[]
            {

                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),

                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                
                new Claim("Permission", user.Permmission.ToString()),

                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                
                new Claim(JwtRegisteredClaimNames.Iat,
                        DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(),
                        ClaimValueTypes.Integer64)
            };


            // Create the symmetric security key used to sign the JWT.
            // This key must match the key used in JWT validation middleware.
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));


            // Define the signing credentials.
            // This specifies the algorithm used to sign the token.
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            int duration = int.Parse(_configuration["Jwt:DurationInMinutes"]);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(duration),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public string GenerateRefreshToken()
        {
            var bytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);

            return Convert.ToBase64String(bytes);
        }

    }
}
