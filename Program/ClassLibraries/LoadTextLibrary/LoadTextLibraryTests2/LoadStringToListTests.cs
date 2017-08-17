using NUnit.Framework;
using LoadTextLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoadTextLibrary.Tests
{
    [TestFixture()]
    public class LoadStringToListTests
    {
        private string GetFilePath(string fileName) // Helper method 
        {
            string path = Directory.GetCurrentDirectory();
            path = Path.Combine(path, "TextExamples");
            path = Path.Combine(path, fileName + ".txt");

            return path;
        }

        private List<string> InitializeListWithWords(string text)
        {
            var ResultList = new List<string>();

            ResultList = text.Split(' ').ToList();

            return ResultList;
        } // Helper method

        private LoadStringToList GetInstanceOfLoadStringToList(string fileName)
        {
            string filePath = GetFilePath(fileName);

            var instance = new LoadStringToList(filePath);

            return instance;
        } // Helper method

        private List<string> InitializeListWithStrings(params string[] input) // Helper method
        {
            List<string> result = new List<string>();

            foreach (string i in input)
                result.Add(i);

            return result;
        }

        [TestCase("First")]
        [TestCase("Pizzagate1")]
        public void filePathRegularTextTest(string fileName)
        {
            string path = GetFilePath(fileName);

            var test = new LoadStringToList(path);

            Assert.AreEqual(path, test.FilePath);
        }

        [TestCase("DoesNotExit")] // Not existing file
        [TestCase("NotValid")] // Not existing file
        public void NotExistingFileExceptionTest(string fileName)
        {
            string path = GetFilePath(fileName);

            Assert.Throws(typeof(FileNotFoundException), () => new LoadEachWordToList(path));
        }

        [TestCase("first", 1)]
        [TestCase("5lines", 5)]
        [TestCase("SeveralLinesWithWhiteSpace", 9)] // 11 lines in text where two of them is whitespace
        public void LinesInGivenTextTest(string fileName, int expectedResult)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList(fileName);

            Assert.AreEqual(expectedResult, test.LinesInText);
        }

        [Test()]
        public void LoadStringToListFromEmptyTextFileTest()
        {
            Assert.Throws(typeof(EmptyTextException), () => GetInstanceOfLoadStringToList("Empty"));
        }

        [TestCase("first", "This is a test")]
        [TestCase("second", "This is a longer text, designed to test the load method")]
        [TestCase("5lines", "This", "text", "have", "5", "lines")]
        public void LoadTextReadLinesFromTextFileTest(string fileName, params string[] expectedResult)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList(fileName);

            List<string> expectedResultList = InitializeListWithStrings(expectedResult);

            CollectionAssert.AreEqual(expectedResultList, test.Lines);
        }

        [TestCase(0, "First line")]
        [TestCase(1, "Second line")]
        [TestCase(2, "fourth line but the third line was whitespace ")]
        [TestCase(9, "Line number 10")]
        public void GetLineAtInRangeIndexTest(int i, string expectedResult)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList("GetLine");

            Assert.AreEqual(expectedResult, test.GetLine(i));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-100)]
        [TestCase(5)] // The text contains four lines 
        [TestCase(10)]
        [TestCase(100)]
        public void GetWordAtOutOfRangeIndexText(int i)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList("5lines");

            Assert.Throws(typeof(IndexOutOfRangeException), () => test.GetLine(i));
        }

        [TestCase("first", 11)]
        [TestCase("5lines", 18)]
        [TestCase("SeveralLines", 98)]
        public void GetAmountOfCharsInGivenTextTest(string fileName, int expectedResult)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList(fileName);

            Assert.AreEqual(expectedResult, test.CharsInText);
        }

        [TestCase("This is the first line", 18)]
        [TestCase("how about this one", 15)]
        public void CountCharsInEachLineTest(string input, int expectedResult)
        {
            LoadStringToList test = GetInstanceOfLoadStringToList("first");

            Assert.AreEqual(expectedResult, test.CountChars(input));
        }

        [Test()]
        public void AmountOfLinesInRealTextTest()
        {
            string path = GetFilePath("Pizzagate1");

            var test = new LoadStringToList(path);

            Assert.AreEqual(38, test.LinesInText);
        }

        [Test()]
        public void AmountOfCharsInRealTextTest()
        {
            string path = GetFilePath("Pizzagate1");

            var test = new LoadStringToList(path);

            Assert.AreEqual(5875, test.CharsInText);
        }

    }
}