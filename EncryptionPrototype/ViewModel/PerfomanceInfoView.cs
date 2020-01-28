using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPrototype.ViewModel
{
    public class PerfomanceInfoView
    {
        public string FileName { get; set; }

        public long FileSize { get; set; }

        public long EncryptFileSize { get; set; }

        public double Conversion { get; set; }

        public long KeyGenerationTime { get; set; }

        public long EncriptionTime { get; set; }

        public long DecriptionTime { get; set; }

        public PerfomanceInfoView(string fileName, long keyGenerationTime, long encriptionTime,
            long decriptionTime, long fileSize, long encryptionFileSize)
        {
            FileName = Path.GetFileName(fileName);
            FileSize = fileSize;
            EncryptFileSize = encryptionFileSize;
            Conversion = Math.Round(100.0 -
                (Convert.ToDouble(Math.Min(FileSize, EncryptFileSize)) / Convert.ToDouble(Math.Max(FileSize, EncryptFileSize))) * 100.0, 2);
            KeyGenerationTime = keyGenerationTime;
            EncriptionTime = encriptionTime;
            DecriptionTime = decriptionTime;
        }
    }
}
