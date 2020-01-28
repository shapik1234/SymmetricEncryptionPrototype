using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStoragePOC
    {
    public class Enums
        {
            public enum FileSize
            {
                Small,
                Medium,
                Large,
                ExtraLarge
            }

            public enum IO
            {
                Read,
                Write
            }

            public enum TypeWR
            {
                Single,
                Bulk,
                MultuThread
            }

            public class TypeWirteRead
            {
                public TypeWR TypeWR { get; set; }
                public int CountThread { get; set; }
            }

            public enum Types
            {
                BLOB,
                FileStream
            }
        }
    }
