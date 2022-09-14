using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Helper
{
    public interface IPasswordHelper
    {
        CreatePasswordHashResult CreateHash(string password);
        bool verifyHash(VerifyPasswordHash verifyPasswordHash);
    }

    public class PasswordHelper : IPasswordHelper
    {
        public CreatePasswordHashResult CreateHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                var salt = hmac.Key;
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                return new CreatePasswordHashResult
                {
                    Hash = hash,
                    Salt = salt
                };
            }
        }

        public bool verifyHash(VerifyPasswordHash verifyPasswordHash)
        {
            using (var hmac = new HMACSHA512(verifyPasswordHash.Salt))
            {
                var computedHash = hmac.ComputeHash(
                    Encoding.UTF8.GetBytes(verifyPasswordHash.Password)
                );
                return computedHash.SequenceEqual(verifyPasswordHash.Hash);
            }
        }
    }

    public struct CreatePasswordHashResult
    {
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
    }

    public struct VerifyPasswordHash
    {
        public string Password { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
    }
}
