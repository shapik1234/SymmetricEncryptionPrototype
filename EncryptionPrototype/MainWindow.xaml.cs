using System.IO;
using System.Windows;
using System.Windows.Controls;
using EncryptionPrototype.DirectoryCrypter;
using EncryptionPrototype.Crypter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using EncryptionPrototype.ViewModel;
using EncryptionPrototype.Crypter.SymmetricAlgorithms;
using System.Security.Cryptography;

namespace EncryptionPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentWorkingFile;

        private static readonly string password = "Why was the birthday cake as hard as a rock? Because it was marble cake!";

        private string[] filesForPerfomanceTest;

        public MainWindow()
        {
            InitializeComponent();

            buttonStartPerfomance.IsEnabled = false;
        }

        private void ButtonCreateDBClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ButtonCreateDBClick");
        }

        private void ButtonBrowseFileClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                currentWorkingFile = dialog.FileName;
                textBoxBrowseFile.Text = currentWorkingFile;
            }
        }

        private void ButtonEncryptClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWorkingFile))
            {
                ConfigureSymmetricAlgorithm configurator = new ConfigureSymmetricAlgorithm(
                    Crypter.Enums.SymmetricAlgorithm.AES,
                    CipherMode.CBC,
                    PaddingMode.ISO10126,
                    128,
                    256);

                FileCipher.EncryptFileWrapper(currentWorkingFile, currentWorkingFile
                    .CreateNameByPredictName("Encrypted"), configurator, password);

                MessageBox.Show("Encrypt done.");
            }
        }

        private void ButtonDecryptClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWorkingFile))
            {
                ConfigureSymmetricAlgorithm configurator = new ConfigureSymmetricAlgorithm(
                    Crypter.Enums.SymmetricAlgorithm.AES,
                    CipherMode.CBC,
                    PaddingMode.ISO10126,
                    128,
                    256);

                FileCipher.DecryptFileWrapper(currentWorkingFile, currentWorkingFile
                    .CreateNameByPredictName("Decrypted"), configurator, password);

                MessageBox.Show("Decrypt done.");
            }
        }

        #region Perfomance Testing

        private void ButtonStartPerfomanceClick(object sender, RoutedEventArgs e)
        {
            InitializePerfomanceView();
        }

        private void InitializePerfomanceView()
        {
            if (filesForPerfomanceTest != null && filesForPerfomanceTest.Length != 0)
            {
                Task.Run(() => DirectoryCipher
                        .FullEncryptionCycleForDirectory(filesForPerfomanceTest))
                    .ContinueWith(task =>
                    {
                        IEnumerable<PerfomanceInfoView> resultPerfomance = task.Result;
                        Dispatcher.Invoke(() => dgGetPerfomanceInfo.ItemsSource = resultPerfomance);
                    });

                buttonStartPerfomance.IsEnabled = false;
            }
        }

        private void ButtonBrowseDirectoryClick(object sender, RoutedEventArgs e)
        {
            using (var fbd = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = fbd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBoxBrowseDirectory.Text = fbd.SelectedPath;
                    filesForPerfomanceTest = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);

                    buttonStartPerfomance.IsEnabled = true;
                }
            }
        }

        private void DataGridGetPerfomance_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: add the logic for display perfomance results in text fields
        }

        #endregion

    }
}
