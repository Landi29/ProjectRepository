using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadTextLibrary;
using System.IO;
using JaccardSimilarityLibrary;

namespace CompareTexts
{
    public class CompareTextUsingJaccardTestClass : CompareTextUsingJaccardSimilarity
    {
        /* This class is used to test CompareTextUsingJaccardSimilarity, since the directory
         * is diffrent. */

        public CompareTextUsingJaccardTestClass(List<string> text, string[] tags) : base(text, tags)
        { }


        /* The directory is diffrent when running test, therefore the below method is overriden and 
         * changed to not add ..\..\..\ to the file path */
        public override List<string> FindDatabaseFilePaths(string tag, string trueOrFalse)
        {
            string directoryName = "Nyheder_Database";
            string path = Directory.GetCurrentDirectory();

            // path = Path.GetFullPath(Path.Combine(path, @"..\..\..\")); // Goes 3 steps up the directory hierarchy

            path = Path.Combine(path, directoryName, tag, trueOrFalse); // Combines the toal path to the wanted directory

            var directoryInformation = new DirectoryInfo(path); // Get information about the directory 

            var filePaths = new List<string>(); // Contains paths to all files in the given directory 

            foreach (FileInfo f in directoryInformation.GetFiles()) // Adds each filepath to the list 
            {
                filePaths.Add(f.FullName);
            }

            return filePaths;
        }

    }
}
