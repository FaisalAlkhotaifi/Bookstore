using Domain.Entities.Account;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Model.Common;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Helper
{
    public interface ITokenHelper 
    {
        string GenerateJwtToken(Account account);
        AppAccount? GetAppAccountByJwtToken(string token);
        bool IsValidaJwtToken(string token);
    }

    public class TokenHelper : ITokenHelper
    {
        private readonly AppSettings _appSettings;

        public TokenHelper(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public string GenerateJwtToken(Account account)
        {
            List<Claim> claims = new List<Claim> {
                new Claim("id", account.Id.ToString()),
                new Claim("email", account.Email),
                new Claim("name", $"{account.FirstName} {account.LastName}"),
                new Claim(ClaimTypes.Role, account.Role)
            };

            return GenerateNewToken(claims);
        }

        public AppAccount? GetAppAccountByJwtToken(string token)
        {
            var jwtToken = ValidateJwtToken(token);
            if (jwtToken == null)
            {
                // return null if validation fails
                return null;
            }

            string accountIdString = jwtToken.Claims.First(x => x.Type == "id").Value;
            bool isValidGuid = Int32.TryParse(accountIdString, out var accountId);

            string accountEmail = jwtToken.Claims.First(x => x.Type == "email").Value;
            string accountName = jwtToken.Claims.First(x => x.Type == "name").Value;
            string role = jwtToken.Claims.First(x => x.Type == "role").Value;

            if (isValidGuid)
            {
                return new AppAccount
                {
                    Id = accountId,
                    Email = accountEmail,
                    Name = accountName,
                    Role = role,
                };
            }
            return null; // return null if fails to get user id from claims
        }

        public bool IsValidaJwtToken(string token)
        {
            var jwtToken = ValidateJwtToken(token);

            return jwtToken != null;
        }

        #region Private Methods

        private byte[] GetKey()
        {
            return Encoding.ASCII.GetBytes(_appSettings.Secret);
        }

        private string GenerateNewToken(List<Claim> claims)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(GetKey()),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private JwtSecurityToken? ValidateJwtToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(GetKey()),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;

                return jwtToken;
            }
            catch
            {
                // return null if validation fails
                return null;
            }
        }

        #endregion
    }
}
