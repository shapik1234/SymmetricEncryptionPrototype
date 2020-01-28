using System;
using System.Security.Cryptography;

namespace EncryptionPrototype.Crypter
{
    internal static class NormalityDistributionKey
    {
        private static readonly int keyLength = 32;

        internal static string GeneratedPassword()
        {
            string password = string.Empty;
            using (var CprytoRNG = RandomNumberGenerator.Create())
            {
                for (int i = 0; i < keyLength; i++)
                {
                    password += RandomIntFromRNG(CprytoRNG);
                }

                return password;
            }
        }
        
        private static char RandomIntFromRNG(RandomNumberGenerator CprytoRNG)
        {
            // Generate two random bytes
            byte[] twoBytes = new byte[2];
            CprytoRNG.GetBytes(twoBytes);

            // Convert the bytes to a Char
            char unicodeSymbol = BitConverter.ToChar(twoBytes, 0);

            return unicodeSymbol;
        }
    }
}
