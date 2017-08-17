using NUnit.Framework;
using ChangeDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDatabase.Tests
{
    [TestFixture()]
    public class CreateArticleFileNameTests
    {
        [TestCase("Filename", 3, 3, 2017, "03_03_2017_Filename.txt")] // day and month with single digit.
        [TestCase("Filename", 03, 03, 2017, "03_03_2017_Filename.txt")] // day and month with double digit.
        [TestCase("Filename", 12, 12, 2017, "12_12_2017_Filename.txt")] // day and month with double digit.
        public void CreateArticleFileNameTestCurrentDate(string FileName, int day, int month, int year, string ExpectedResult)
        {
            DateTime Date = new DateTime(year, month, day);
            var test = new CreateArticleFileName(FileName, Date);
            Assert.AreEqual(ExpectedResult, test.ArticleName);
        }

        [TestCase("Filename", "01", "04", "2017", "01_04_2017_Filename.txt")] //Standard test.
        [TestCase("Filename.txt", "01", "04", "2017", "01_04_2017_Filename.txt.txt")] // double .txt
        [TestCase("Filename1", "31", "12", "2017", "31_12_2017_Filename1.txt")] // max range date
        [TestCase("Filename2", "01", "01", "0001", "01_01_0001_Filename2.txt")] // lowest range date
        [TestCase("Filename3", "1", "2", "2017", "01_02_2017_Filename3.txt")] // Changed d/M to dd/MM
        public void CreateArticleFileNameTestUserDate(string FileName, string Day, string Month, string Year, string ExpectedResult)
        {
            var test = new CreateArticleFileName(FileName, Day, Month, Year);
            Assert.AreEqual(ExpectedResult, test.ArticleName);
        }



        [TestCase("Filename", "32", "04", "2017", typeof(InvalidDateException))] // Too high day value
        [TestCase("Filename", "01", "13", "2017", typeof(InvalidDateException))] // Too high month value
        [TestCase("Filename", "01", "04", "9999", typeof(InvalidDateException))] // Too high year value
        [TestCase("Filename", "-12", "-4", "-47", typeof(InvalidDateException))] // Negative values
        [TestCase("", "01", "04", "2017", typeof(InvalidDateException))] // No Filename
        [TestCase("Filename", "", "","",typeof(InvalidDateException))] // Empty dates
        [TestCase("", "", "", "", typeof(InvalidDateException))] // No input
        [TestCase("Filename", "ab", "cd", "ef", typeof(InvalidDateException))] // char dates
        public void CreateArticleFileNameTestCatchException(string FileName, string Day, string Month, string Year, Type ExpectedResult)
        {
            Assert.Throws(ExpectedResult, () => new CreateArticleFileName(FileName, Day, Month, Year));
        }
    }
}