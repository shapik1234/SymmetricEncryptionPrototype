namespace FileStoragePOC.Models
{
    public class Params
    {
        public bool Encryption { get; set; }

        public Enums.FileSize FileSize { get; set; }

        public Enums.IO Io { get; set; }

        public Enums.TypeWirteRead TypeWirteRead { get; set; }

        public Enums.Types Type { get; set; }
    }
}