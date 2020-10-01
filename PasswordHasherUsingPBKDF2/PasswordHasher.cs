using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordHasherUsingPBKDF2
{
    public static class PasswordHasher
    {
        public static string Create(string value, string salt)
        {
            try
            {
                var valueBytes = KeyDerivation.Pbkdf2(
                                               password: value,
                                               salt: Encoding.UTF8.GetBytes(salt),
                                               prf: KeyDerivationPrf.HMACSHA512,
                                               iterationCount: 10000,
                                               numBytesRequested: 256 / 8);

                return Convert.ToBase64String(valueBytes);
            }
            catch (Exception ex)
            {

                throw;
            }

          

        }
        public static bool Validate(string value, string salt, string hash)
        => Create(value, salt) == hash;
    }
}
