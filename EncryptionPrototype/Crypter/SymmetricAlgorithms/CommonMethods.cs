using EncryptionPrototype.Crypter.SymmetricAlgorithms;
using System.Security.Cryptography;
using SymmetricAlgorithm = EncryptionPrototype.Crypter.Enums.SymmetricAlgorithm;

namespace EncryptionPrototype.Crypter
{
    internal class CommonMethods
    {
        internal static System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgoritm(ConfigureSymmetricAlgorithm configurator)
        {
            System.Security.Cryptography.SymmetricAlgorithm algorithm;
            switch (configurator.Algorithm)
            {
                case SymmetricAlgorithm.AES:
                    algorithm = new AesManaged()
                    {
                        BlockSize = configurator.BlockSize,
                        Mode = configurator.Mode,
                        KeySize = configurator.KeySize,
                        Padding = configurator.PaddingMode,
                    };
                    break;
                case SymmetricAlgorithm.TripleDES:
                    algorithm = new TripleDESCryptoServiceProvider()
                    {
                        BlockSize = configurator.BlockSize,
                        Padding = configurator.PaddingMode,
                        KeySize = configurator.KeySize,
                        Mode = configurator.Mode,
                    };
                    break;
                case SymmetricAlgorithm.Rijndael:
                    algorithm = new RijndaelManaged()
                    {
                        KeySize = configurator.KeySize,
                        Padding = configurator.PaddingMode,
                        BlockSize = configurator.BlockSize,
                        Mode = configurator.Mode,
                    };
                    break;
                case SymmetricAlgorithm.Rc2:
                    algorithm = new RC2CryptoServiceProvider()
                    {
                        BlockSize = configurator.BlockSize,
                        KeySize = configurator.KeySize,
                        Padding = configurator.PaddingMode,
                        Mode = configurator.Mode,
                    };
                    break;
                default:
                    algorithm = null;
                    break;
            }

            return algorithm;
        }
    }
}
