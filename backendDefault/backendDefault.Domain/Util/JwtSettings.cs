using backendDefault.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace backendDefault.Domain.Util
{
    public class JwtSettings
    {
        private static readonly string Secret = "43e4dbf0-52ed-4203-895d-42b7627499780ne1";

        public static readonly string UserId = ClaimTypes.PrimarySid;
        public static readonly string UserName = ClaimTypes.Name;
        public static readonly string UserEmail = ClaimTypes.Email;

        public static readonly string UserType = "sistema";
        public static readonly string UserTypeUser = "User";

        public static byte[] GetKey() => Encoding.ASCII.GetBytes(Secret);


        public static string GenerateUserToken(TblUser User, int empreendimento)
        {
            var Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(UserName, User.Nome),
                new Claim(UserEmail, User.Email),
                new Claim(UserId, $"{User.IdUsuario}"),
                new Claim(UserType, UserTypeUser)
            });
            return GenerateToken(Subject);
        }

        private static string GenerateToken(ClaimsIdentity Subject)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = Subject,
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
