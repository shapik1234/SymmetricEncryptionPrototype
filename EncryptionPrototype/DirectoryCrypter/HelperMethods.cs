using System;
using System.Linq;

namespace EncryptionPrototype.DirectoryCrypter
{
    internal static class HelperMethods
    {
        internal static string CreateNameByPredictName(this string fullName, string predictAdding)
        {
            string newName = string.Empty;
            for (int i = fullName.Length - 1; i > 0; i--)
            {
                if (fullName[i].Equals('.'))
                {
                    newName = fullName.Substring(0, i) + predictAdding + fullName.Substring(i, fullName.Length - i);
                    break;
                }

                if (fullName[i].Equals('\\'))
                {
                    break;
                }
            }

            if (newName.Equals(string.Empty))
            {
                newName = fullName + predictAdding;
            }

            return newName;
        }
    }
}
