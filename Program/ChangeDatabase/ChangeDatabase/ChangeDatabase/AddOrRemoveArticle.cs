using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PathMakerToDatabase;

namespace ChangeDatabase
{
    public class AddOrRemoveArticle
    {
        #region Members
        private List<string> Article = new List<string>();
        private string FileName;
        private string ArticlePath;
        private string TrueOrFalse;
        private string Content;
        #endregion

        // Input from User Input or Fake News result.
        public AddOrRemoveArticle(List<string> Article, string FileName) : this(FileName)
        {
            this.Article = Article;
        }

        // Removes all instances of certain article.
        public AddOrRemoveArticle(string FileName)
        {
            this.FileName = FileName;
            PathToDatabase CreatePath = new PathToDatabase();
            ArticlePath = CreatePath.PathToArticleDatabase;
        }

        public void RemoveArticleFromDatabase()
        {
            // Directory info of Database.
            DirectoryInfo DatabaseDirectories = new DirectoryInfo(ArticlePath);
            // Goes through all tags in database
            foreach(DirectoryInfo Tags in DatabaseDirectories.GetDirectories())
            {
                // Goes through the Tag True and False folders.
                foreach(DirectoryInfo TrueOrFalseFolder in Tags.GetDirectories())
                {
                    // Goes through all articles in of the Tag true or False folder.
                    foreach(FileInfo Article in TrueOrFalseFolder.GetFiles())
                    {
                        // If article matches the input article, remove it.
                        if(Article.Name == FileName)
                        {
                            Article.Delete();
                        }
                    }
                }
            }
        }

        public void RemoveArticleFromTag(string Tag)
        {
            // Creating source and destionation path for True file instance.
            string TrueTargetPath = Path.Combine(ArticlePath, Tag, "True", FileName);
            FileInfo TrueArticle = new FileInfo(TrueTargetPath);
            if (TrueArticle.Exists)
            {
                TrueArticle.Delete();
            }
            // Creating source and destionation path for False file instance.
            string FalseTargetPath = Path.Combine(ArticlePath, Tag, "False", FileName);
            FileInfo FalseArticle = new FileInfo(FalseTargetPath);
            if(FalseArticle.Exists)
            {
                FalseArticle.Delete();
            }
        }

        public void AddArticle(string userChoice, string TrueOrFalse, List<string> tags)
        {
            this.TrueOrFalse = TrueOrFalse;
            DirectoryInfo dirInfo = new DirectoryInfo(ArticlePath);

            // If user has chosen to add article to a number of current tags.
            if (userChoice == "CurrentTag")
            {
                foreach (string tag in tags)
                {
                    CreateFile(Path.Combine(dirInfo.ToString(), tag));
                }
            }
            // If user has chosen to add article to a new tag.
            else if (userChoice == "NewTag")
            {
                foreach (string tag in tags)
                {
                    string pathToTag = Path.Combine(dirInfo.ToString(), tag);
                    CreateDirectoryTag(pathToTag);
                    CreateFile(pathToTag);
                }
            }
        }

        // Adds the article to All_articles in the database. 
        public void FinishAddArticle(string TrueOrFalse)
        {
            this.TrueOrFalse = TrueOrFalse;
            DirectoryInfo dirInfo = new DirectoryInfo(ArticlePath);
            CreateFile(Path.Combine(dirInfo.ToString(), "All_articles"));
        }
        private void CreateDirectoryTag(string path)
        {
            Directory.CreateDirectory(path); //Creates the tag.
            Directory.CreateDirectory(Path.Combine(path, "True")); //Creates True and False sub-folders.
            Directory.CreateDirectory(Path.Combine(path, "False"));
        }

        private void CreateFile(string PathToTag)
        {
            PathToTag = Path.Combine(PathToTag, TrueOrFalse);
            
            // Creates path for file and name.
            string destFile = Path.Combine(PathToTag, FileName);
            // Makes sure nothing is overwritten.
            if (!File.Exists(destFile))
            {
                foreach (string word in Article)
                {
                    Content += word + " ";
                }
                File.WriteAllText(destFile, Content);
            }
        }
    }
}