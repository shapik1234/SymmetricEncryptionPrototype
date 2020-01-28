using System;
using System.Security.Cryptography;

namespace EncryptionPrototype.Crypter.SymmetricAlgorithms
{
    internal class ConfigureSymmetricAlgorithm
    {
        public Enums.SymmetricAlgorithm Algorithm { get; }

        public int KeySize { get; private set; }

        public int BlockSize { get; private set; }

        public PaddingMode PaddingMode { get; private set; }

        public CipherMode Mode { get; private set; }

        public ConfigureSymmetricAlgorithm(
            Enums.SymmetricAlgorithm algorithm,
            CipherMode mode,
            PaddingMode paddingMode,
            int blockSize,
            int keySize)
        {
            Algorithm = algorithm;

            Mode = mode;

            #region Check key size

            var mod = keySize % 8;
            keySize -= mod;

            #endregion

            if (paddingMode == PaddingMode.ANSIX923 || paddingMode == PaddingMode.PKCS7 || paddingMode == PaddingMode.Zeros)
            {
                PaddingMode = PaddingMode.ISO10126;
            }
            else
            {
                PaddingMode = paddingMode;
            }

            switch (algorithm)
            {
                case Enums.SymmetricAlgorithm.AES:
                    ConfigureAes(blockSize, keySize);
                    break;
                case Enums.SymmetricAlgorithm.TripleDES:
                    ConfigureTripleDes(blockSize, keySize);
                    break;
                case Enums.SymmetricAlgorithm.Rijndael:
                    ConfigureRijndael(blockSize, keySize);
                    break;
                case Enums.SymmetricAlgorithm.Rc2:
                    ConfigureRc2(blockSize, keySize);
                    break;
                default:
                    throw new ArgumentException("algorithm name");
            }
        }
        
        private void ConfigureRijndael(
            int blockSize,
            int keySize)
        {
            if (blockSize > 128 && blockSize < 256 && blockSize % 32 == 0)
            {
                BlockSize = blockSize;
            }
            else
            {
                BlockSize = 256;
            }

            if (keySize > 128 && keySize < 256 && keySize % 32 == 0)
            {
                KeySize = keySize;
            }
            else
            {
                KeySize = 256;
            }
        }

        private void ConfigureAes(
            int blockSize,
            int keySize)
        {
            BlockSize = 128;

            if (keySize != 128 || keySize != 192 || keySize != 256)
            {
                KeySize = 256;
            }
            else
            {
                KeySize = keySize;
            }
        }

        private void ConfigureTripleDes(
            int blockSize,
            int keySize)
        {
            //56 - 7 bit
            BlockSize = 64; 
            //168 - 7 bit
            KeySize = 192;
        }

        private void ConfigureRc2(
            int blockSize,
            int keySize)
        {
            BlockSize = 64;

            if (keySize > 8 && keySize < 128)
            {
                KeySize = keySize;
            }
            else
            {
                KeySize = 128;
            }
        }
    }
}
