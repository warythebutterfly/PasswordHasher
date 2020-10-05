using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordHasherUsingPBKDF2
{
    public static class Salt
    {
        public static string Create()
        {
            var rng = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[128 / 8];
            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            rng.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }
    }
}
