using System;
using System.IO;
using System.Windows;
using EncryptionPrototype.Crypter.SymmetricAlgorithms;

namespace EncryptionPrototype.Crypter
{
    internal class FileCipher
    {
        #region Work with file stream

        private static void ProcessFile(string sourceFileName, string outputFileName, ConfigureSymmetricAlgorithm configurator, string key,
            Action<Stream, Stream, ConfigureSymmetricAlgorithm, string> routine)
        {
            using (FileStream sourceStream = File.OpenRead(sourceFileName))
            {
                using (FileStream outputStream = File.Create(outputFileName))
                {
                    routine(sourceStream, outputStream, configurator, key);
                }
            }
        }

        private static void EncryptFile(string sourceFileName, string cryptedFileName, ConfigureSymmetricAlgorithm configurator, string key)
            => ProcessFile(sourceFileName, cryptedFileName, configurator, key, CipherStream.EncryptProcess);

        private static void DecryptFile(string cryptedFileName, string outputFileName, ConfigureSymmetricAlgorithm configurator, string key)
            => ProcessFile(cryptedFileName, outputFileName, configurator, key, CipherStream.DecryptProcces);

        public static void EncryptFileWrapper(string sourceFileName, string cryptedFileName, ConfigureSymmetricAlgorithm configurator, string key)
        {
            try
            {
                EncryptFile(sourceFileName, cryptedFileName, configurator, key);
            }
            catch (Exception e)
            {
               MessageBox.Show(e.ToString(), "Exception");
            }
        }

        public static void DecryptFileWrapper(string cryptedFileName, string outputFileName, ConfigureSymmetricAlgorithm configurator, string key)
        {
            try
            {
                DecryptFile(cryptedFileName, outputFileName, configurator, key);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception");
            }
        }

        #endregion
    }
}
