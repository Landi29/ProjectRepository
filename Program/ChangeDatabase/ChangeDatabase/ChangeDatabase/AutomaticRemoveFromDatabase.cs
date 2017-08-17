using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PathMakerToDatabase;

namespace ChangeDatabase
{
    public class AutomaticRemoveFromDatabase
    {
        public void FindOutdatedFolder()
        {
            // Creates the directory for database, and loops through all tags.
            PathToDatabase PathCreator = new PathToDatabase();
            DirectoryInfo Dir = new DirectoryInfo(PathCreator.PathToArticleDatabase);
            foreach (DirectoryInfo Tag in Dir.GetDirectories())
            {
                BrowseTags(Tag);
            }
        }

        private void BrowseTags(DirectoryInfo Dir)
        {
            // Creates paths for selected tags True and False folders.
            DirectoryInfo DirTrue = new DirectoryInfo(Path.Combine(Dir.FullName, "True"));
            DirectoryInfo DirFalse = new DirectoryInfo(Path.Combine(Dir.FullName, "False"));

            // Goes through all true articles
            foreach (FileInfo file in DirTrue.GetFiles())
                FindOutdatedFile(file.ToString(), file);

            // Goes through all false articles
            foreach (FileInfo file in DirFalse.GetFiles())
                FindOutdatedFile(file.ToString(), file);
        }

        private void FindOutdatedFile(string File, FileInfo FileInformation)
        {
            try
            {
                int day = Int32.Parse(File.Substring(0, 2)); // Converts 2 first chars to day.
                int month = Int32.Parse(File.Substring(3, 2)); // Converts char 3-5 to month.
                int year = Int32.Parse(File.Substring(6, 4)); // Converts char 6-10 to year.
                DateTime CurrentTime = DateTime.Now;

                // If an article has an invalid Date.
                if (year > CurrentTime.Year || year < 0 || month > 12 || month < 0 || day > 31 || day < 0)
                    throw new InvalidDateException();

                // If article year is equal to current year -1.
                if (year == (CurrentTime.Year - 1))
                {
                    // If article month is same as current month.
                    if (month == CurrentTime.Month)
                    {
                        // If current day is bigger than create day, remove it.
                        if (day < CurrentTime.Day)
                            RemoveFile(FileInformation);
                    }
                    // If month is before current month.
                    else if (month < CurrentTime.Month)
                        RemoveFile(FileInformation);
                }
                // If article is older than 1 year, remove it. Else do nothing.
                else if (year < CurrentTime.Year -1)
                {
                    RemoveFile(FileInformation);
                }
            }
            // If the file name has an error, like an invalid date: 39_14_2090, or does not meet the requirements: Name_01_01_2010.
            // Catched exceptions is deleted.
            catch (FormatException)
            {
                RemoveFile(FileInformation);
            }
            catch (InvalidDateException)
            {
                RemoveFile(FileInformation);
            }
        }

        private void RemoveFile(FileInfo FileInformation)
        {
            FileInformation.Delete();
        }
    }
}