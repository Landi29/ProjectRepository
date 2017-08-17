using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDatabase
{
    public class CreateArticleFileName
    {
        public string ArticleName { get; private set; }
        string FileName;
        string Year;
        string Month;
        string Day;

        public CreateArticleFileName(string FileName, DateTime Date)
        {
            this.FileName = FileName;
            // Converts the DateTime to string, with the format yyyy, mm, dd.
            this.Day = Date.Day.ToString("d2");
            this.Month = Date.Month.ToString("d2");
            this.Year = Date.Year.ToString("d4");
            ArticleName = CreateName();
        }
        public CreateArticleFileName(string FileName, string Day, string Month, string Year)
        {
            this.FileName = FileName;
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            ValidateDate();
            ArticleName = CreateName();
        }

        private void ValidateDate()
        {
            int localYear, localMonth, localDay;
            bool ValidDate = true;
            // Makes sure Filename isn't empty.
            if (FileName.Count() > 0)
            {
                // Makes sure day, month and year are ints.
                if (int.TryParse(Year, out localYear) && int.TryParse(Month, out localMonth) && int.TryParse(Day, out localDay))
                {
                    // Makes sure the date is valid.
                    if (!(localYear > DateTime.Now.Year || localYear < 0 || Year.Count() != 4 || localMonth > 12 || localMonth < 0 || localDay > 31 || localDay < 0))
                    {
                        // Makes sure month is of format mm.
                        if (Month.Count() != 2)
                            Month = "0" + Month;

                        // Makes sure day is of format dd.
                        if (Day.Count() != 2)
                            Day = "0" + Day;
                    }
                    else
                        ValidDate = false;
                }
                else
                    ValidDate = false;
            }
            else
                ValidDate = false;

            // If input date is invalid, throw InvalidDateException to GUI.
            if(ValidDate == false)
                throw new InvalidDateException($"Invalid date {Day}-{Month}-{Year}. Please try again with format DD MM YYYY");
        }

        private string CreateName()
        {
            string ArticleName;
            //Creates article name of format dd_mm_yyyy_name.txt
            ArticleName = Day + "_" + Month + "_" + Year + "_" + FileName + ".txt";
            return ArticleName;
        }
    }
}
