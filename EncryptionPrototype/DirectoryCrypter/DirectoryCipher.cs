using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using EncryptionPrototype.Crypter;
using EncryptionPrototype.ViewModel;
using EncryptionPrototype.Crypter.SymmetricAlgorithms;
using SymmetricAlgorithm = EncryptionPrototype.Crypter.Enums.SymmetricAlgorithm;

namespace EncryptionPrototype.DirectoryCrypter
{
    public class DirectoryCipher
    {
        public static IEnumerable<PerfomanceInfoView> FullEncryptionCycleForDirectory(IEnumerable<string> fileNames)
        {
            Stopwatch stopwatch = new Stopwatch();

            ConfigureSymmetricAlgorithm configurator = new ConfigureSymmetricAlgorithm(
                SymmetricAlgorithm.AES,
                CipherMode.CBC,
                PaddingMode.ISO10126,
                128,
                256);

            foreach (var file in fileNames)
            {
                var encryptFileName = file.CreateNameByPredictName("Encrypted");
                var decryptFileName = file.CreateNameByPredictName("Decrypted");

                stopwatch.Restart();
                string key = NormalityDistributionKey.GeneratedPassword();
                stopwatch.Stop();
                var keyTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                FileCipher.EncryptFileWrapper(file, encryptFileName, configurator, key);
                stopwatch.Stop();
                var encryptTime = stopwatch.ElapsedMilliseconds;

                stopwatch.Restart();
                FileCipher.DecryptFileWrapper(encryptFileName, decryptFileName, configurator, key);
                stopwatch.Stop();
                var decryptTime = stopwatch.ElapsedMilliseconds;


                yield return new PerfomanceInfoView(
                    file,
                    keyTime,
                    encryptTime,
                    decryptTime,
                    new System.IO.FileInfo(file).Length,
                    new System.IO.FileInfo(encryptFileName).Length);
            }
        }
    }
}
