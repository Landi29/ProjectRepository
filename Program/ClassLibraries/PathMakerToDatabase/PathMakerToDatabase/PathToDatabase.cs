using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PathMakerToDatabase
{
    public class PathToDatabase
    {
        // Main pain to database.
        public string PathToArticleDatabase { get; private set; }
        // Path to project folder. - Used for test.
        public string PathToProject { get; private set; }

        public PathToDatabase() : this("Nyheder_Database")
        {}

        public PathToDatabase(string DirectoryName)
        {
            string path = Directory.GetCurrentDirectory();

            // Goes 3 folders up.
            path = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            PathToProject = path; // Creates the path to project folder.

            // Combines path with selected directory name.
            path = Path.Combine(path, DirectoryName);
            DirectoryInfo FilePath = new DirectoryInfo(path);
            PathToArticleDatabase = path; // Creates the path to database folder, or selected folder.
        }
    }
}
