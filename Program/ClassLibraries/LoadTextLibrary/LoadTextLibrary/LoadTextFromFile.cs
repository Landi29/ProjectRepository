using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTextLibrary
{
    public abstract class LoadTextFromFile
    {
        public string FilePath { get; protected set; } // Navnet på filen, som skal indlæses

        public LoadTextFromFile(string filePath)
        {
            this.FilePath = filePath;
        }

        public abstract void LoadText();
    }
}
