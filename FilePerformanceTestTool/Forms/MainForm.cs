using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FileStoragePOC.Models;

namespace FileStoragePOC
{
    public partial class DataTransferDiagnosting : Form
    {
        List<string> databasesList = new List<string>();
        SqlConnection currentConnection = DataServerHelper.EstablishConnection();

        static readonly Random random = new Random();
        private static readonly string mainFolder = "Files";
        private static readonly string smallFiles = "SmallFiles";

        private BindingSource bs;

        public DataTransferDiagnosting()
        {
            currentConnection.Open();
            InitializeComponent();
            if (DataServerHelper.EstablishConnection() != null)
            {
                ConnectedServerStatusLabel.Text =
                    DataServerHelper.EstablishConnection().DataSource;
                databasesList = DataServerHelper.GetDatabaseNames(currentConnection);
                DatabasesDropDownButton.DropDownItems.Clear();
                foreach (var item in DataServerHelper.GetDatabaseNames(currentConnection))
                {
                    DatabasesDropDownButton.DropDownItems.Add(item);
                }

                DatabasesDropDownButton.Text = databasesList.FirstOrDefault();
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            Process.Start($@"{AppDomain.CurrentDomain.BaseDirectory}\{mainFolder}\{smallFiles}");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!ValidatParams())
            {
                return;
            }

            var paramsModel = GetParamsModel();
            Thread.Sleep(2000);

            dataGridViewResult.DataSource = GetListResults();
            dataGridViewCommonResult.DataSource = CommonResult();

            Cursor.Current = Cursors.Default;
        }

        #region Other

        private static List<Result> GetListResults()
        {
            return new List<Result>
            {
                new Result {FileName = "1.pdf", WriteRead = random.NextDouble(), Encryption = random.NextDouble()},
                new Result {FileName = "2.pdf", WriteRead = random.NextDouble(), Encryption = random.NextDouble()}
            };
        }

        private bool ValidatParams()
        {
            var FileSizeGB = groupBoxFileSize.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var IO = groupBoxIO.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var TypeReadWrite = groupBoxTypeReadWrite.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var Types = groupBoxTypes.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            return validateRadioButtons(FileSizeGB, "Select File Size")
                   & validateRadioButtons(IO, "Select IO")
                   & validateRadioButtons(Types, "Select Types")
                   & ValidateTypeReadWrite(TypeReadWrite);
        }

        private bool ValidateTypeReadWrite(RadioButton TypeReadWrite)
        {
            bool validateTypeReadWrite = validateRadioButtons(TypeReadWrite, "Select Type Read Write");

            if (validateTypeReadWrite && TypeReadWrite.Text == "Multi Thread")
            {
                if ((int) numericUpDownCountThread.Value == 0)
                {
                    MessageBox.Show("Need increase count thread");
                    validateTypeReadWrite = false;
                }
            }

            return validateTypeReadWrite;
        }

        private bool validateRadioButtons(RadioButton radioButton, string mainTextErrors)
        {
            if (radioButton == null)
            {
                MessageBox.Show(mainTextErrors);
                return false;
            }

            return true;
        }

        private object CommonResult()
        {
            var result = dataGridViewResult.DataSource as List<Result>;
            if (result == null) throw new ArgumentNullException(nameof(result));

            return new List<CommonResult>
            {
                new CommonResult
                {
                    AVGWriteRead = result.Average(wr => wr.WriteRead),
                    TotalWriteRead = result.Sum(wr => wr.WriteRead),
                    AVGEncryption = result.Average(en => en.Encryption),
                    TotalEncryption = result.Sum(en => en.Encryption)
                }
            };
        }

        private Params GetParamsModel()
        {
            return new Params
            {
                Encryption = checkBoxEncryption.Checked,
                FileSize = GetFileSize(),
                Io = GetIo(),
                TypeWirteRead = GetTypeWirteRead(),
                Type = GetTypes()
            };
        }

        private Enums.Types GetTypes()
        {
            var Types = groupBoxTypes.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            switch (Types.Text)
            {
                case "BLOB":
                    return Enums.Types.BLOB;
                case "FileStream":
                    return Enums.Types.FileStream;
                default:
                    throw new NullReferenceException();
            }
        }

        private Enums.TypeWirteRead GetTypeWirteRead()
        {
            var typeWirteRead = groupBoxTypeReadWrite.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            Enums.TypeWR typeWR;


            switch (typeWirteRead.Text)
            {
                case "Single":
                    typeWR = Enums.TypeWR.Single;
                    break;
                case "Bulk":
                    typeWR = Enums.TypeWR.Bulk;
                    break;
                case "Multi Thread":
                    typeWR = Enums.TypeWR.MultuThread;
                    break;
                default:
                    throw new NullReferenceException();
            }

            return new Enums.TypeWirteRead
            {
                TypeWR = typeWR,
                CountThread = typeWR == Enums.TypeWR.MultuThread ? (int) numericUpDownCountThread.Value : default(int)
            };
        }

        private Enums.IO GetIo()
        {
            var io = groupBoxIO.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            switch (io.Text)
            {
                case "Read":
                    return Enums.IO.Read;
                case "Write":
                    return Enums.IO.Write;
                default:
                    throw new NullReferenceException();
            }
        }

        private Enums.FileSize GetFileSize()
        {
            var fileSize = groupBoxFileSize.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            switch (fileSize.Text)
            {
                case "Small: < 1Mb":
                    return Enums.FileSize.Small;
                case "Medium: 1-3Mb":
                    return Enums.FileSize.Medium;
                case "Large: 3-10Mb":
                    return Enums.FileSize.Large;
                case "ExtraLarge: >10Mb":
                    return Enums.FileSize.ExtraLarge;
                default:
                    throw new NullReferenceException();
            }
        }

        #endregion

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectedServerStatusLabel.Text = DataServerHelper.ChangeConnection(currentConnection).DataSource;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatabasesDropDownButton_Click(object sender, EventArgs e)
        {
        }
    }
}