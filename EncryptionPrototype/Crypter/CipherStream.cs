using System;
using System.IO;
using System.Security.Cryptography;
using EncryptionPrototype.Crypter.SymmetricAlgorithms;

namespace EncryptionPrototype.Crypter
{
    internal static class CipherStream
    {
        //salt size
        private static readonly int saltSize = 32;

        //standart hash count iteration 
        private static readonly int hashIterationCount = 1024;

        internal static void EncryptProcess(Stream sourceStream, Stream destStream, ConfigureSymmetricAlgorithm configurator, string key)
        {
            if (sourceStream == null || !sourceStream.CanRead || sourceStream.Length == 0)
            {
                throw new ArgumentNullException("sourceStream");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            // Derive a new Salt and IV from the Key
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, saltSize, hashIterationCount))
            {
                var saltBytes = keyDerivationFunction.Salt;
                var keyBytes = keyDerivationFunction.GetBytes(configurator.KeySize/8);
                var ivBytes = keyDerivationFunction.GetBytes(16);

                // Write a new Salt in Stream for Decription Method
                destStream.Write(saltBytes, 0, saltSize);
                 
                // Create an encryptor to perform the stream transform.
                using (var managed = CommonMethods.GetSymmetricAlgoritm(configurator))
                {
                    using (var encryptor = managed.CreateEncryptor(keyBytes, ivBytes))
                    {
                        CryptoProcess(sourceStream, destStream, encryptor);
                    }
                }
            }
        }

        internal static void DecryptProcces(Stream encryptStream, Stream destStream, ConfigureSymmetricAlgorithm configurator, string key)
        {
            if (encryptStream == null || !encryptStream.CanRead || encryptStream.Length == 0)
            {
                throw new ArgumentNullException("encryptedStream");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            // Extract the salt from our ciphertext
            var saltBytes = new byte[saltSize];
            encryptStream.Read(saltBytes, 0, saltSize);

            using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, saltBytes, hashIterationCount))
            {
                // Derive the previous IV from the Key and Salt
                var keyBytes = keyDerivationFunction.GetBytes(configurator.KeySize / 8);
                var ivBytes = keyDerivationFunction.GetBytes(16);

                // Create a decrytor to perform the stream transform.
                using (var managed = CommonMethods.GetSymmetricAlgoritm(configurator))
                {
                    using (var decryptor = managed.CreateDecryptor(keyBytes, ivBytes))
                    {
                        CryptoProcess(encryptStream, destStream, decryptor);
                    }
                }
            }
        }

        private static void CryptoProcess(Stream sourceStream, Stream destStream, ICryptoTransform encryptor)
        {
            CryptoStream cryptoStream = new CryptoStream(destStream, encryptor, CryptoStreamMode.Write);
            using (BinaryReader reader = new BinaryReader(sourceStream))
            {
                byte[] buffer = new byte[81920];
                int count = 81920;
                int position = 0;
                while ((count = reader.Read(buffer, position, count)) > 0)
                {
                    cryptoStream.Write(buffer, 0, count);
                }
            }

            cryptoStream.FlushFinalBlock();
        }
    }
}
