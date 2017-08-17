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
    public class LoadEachWordToListTests
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

        [TestCase("First")]
        [TestCase("Pizzagate1")]
        public void filePathRegularTextTest(string fileName)
        {
            string path = GetFilePath(fileName);

            var test = new LoadEachWordToList(path);

            Assert.AreEqual(path, test.FilePath);
        }

        [TestCase("DoesNotExit")] // Not existing file
        [TestCase("NotValid")] // Not existing file
        public void NotExistingFileExceptionTest(string fileName)
        {
            string path = GetFilePath(fileName);

            Assert.Throws(typeof(FileNotFoundException), () => new LoadEachWordToList(path));
        }

        [TestCase("First", "This is a test")] 
        [TestCase("Second", "This is a longer text designed to test the load method")]
        public void LoadTextIntoTheStringArrayEachWordsTest(string fileName, string expectedResult)
        {
            string path = GetFilePath(fileName);

            var test = new LoadEachWordToList(path);

            List<string> expectedResultList = InitializeListWithWords(expectedResult);

            CollectionAssert.AreEqual(expectedResultList, test.EachWord);
        }

        [Test()]
        public void LoadEachWordIntoListFromEmptyTextFileTest()
        {
            string path = GetFilePath("Empty");

            Assert.Throws(typeof(EmptyTextException), () => new LoadEachWordToList(path));
        }

        [TestCase("First", "This is a test")]
        [TestCase("Second", "This is a longer text designed to test the load method")]
        public void LoadTextIntoTheListWordsTest(string fileName, string expectedResult)
        {
            string path = GetFilePath(fileName);

            var test = new LoadEachWordToList(path);

            List<string> expectedResultList = InitializeListWithWords(expectedResult);

            CollectionAssert.AreEqual(expectedResultList, test.Words);
        }

        [TestCase(0, "This")]
        [TestCase(1, "is")]
        [TestCase(2, "a")]
        [TestCase(3, "test")]
        public void GetWordAtInRangeIndexTest(int i, string expectedResult)
        {
            string path = GetFilePath("first");

            var test = new LoadEachWordToList(path);

            Assert.AreEqual(expectedResult, test.GetWord(i));
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-100)]
        [TestCase(4)]
        [TestCase(10)]
        [TestCase(100)]
        public void GetWordAtOutOfRangeIndexText(int i)
        {
            string path = GetFilePath("first");

            var test = new LoadEachWordToList(path);

            Assert.Throws(typeof(IndexOutOfRangeException), () => test.GetWord(i));
        }

        [TestCase("Seperators", "This is a test which contains all stringseperators and also multiple lines")]
        public void StringSeperatorInLoadTextTest(string fileName, string expectedResult)
        {
            string path = GetFilePath(fileName);

            var test = new LoadEachWordToList(path);

            List<string> expectedResultList = InitializeListWithWords(expectedResult);

            CollectionAssert.AreEqual(expectedResultList, test.Words);
        }

        [Test()]
        public void AmountOfWordsLoadedFromRealTextTest()
        {
            string path = GetFilePath("Pizzagate1");

            var test = new LoadEachWordToList(path);

            Assert.AreEqual(1200, test.Words.Count());
        }
    }
}