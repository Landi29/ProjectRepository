using NUnit.Framework;
using LoadTextLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTextLibrary.Tests
{
    [TestFixture()]
    public class ListSplitSentencesToWordsTests
    {
        private List<string> InitializeListWithWords(string text)
        {
            var ResultList = new List<string>();

            ResultList = text.Split(' ').ToList();

            return ResultList;
        } // Helper method

        private List<string> InitializeListWithArrayOfWords(string[] words) // Helper Method
        {
            var result = new List<string>();

            foreach (string word in words)
                result.Add(word);

            return result;
        }

        [TestCase("This is a test", "This", "is", "a", "test")]
        [TestCase("We can also try a little longer text", "We", "can", "also", "try", "a", "little", "longer", "text")]
        [TestCase("a,b.c!d?e;f:g h-i\\j(k)l/m","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m")] // Test for seperators
        public void PopulatedListSplitSentencesToWordsResultTest(string input, params string[] expectedResult)
        {
            List<string> inputList = InitializeListWithWords(input);
            List<string> expectedResultList = InitializeListWithArrayOfWords(expectedResult);

            var test = new ListSplitSentencesToWords(inputList);

            CollectionAssert.AreEqual(expectedResultList, test.Result);
        }

        [TestCase("This is a test", "This is a test")]
        [TestCase("We can also try a little longer text", "We can also try a little longer text")]
        public void PopulatedListInputTest(string input, string expectedResult)
        {
            List<string> inputList = InitializeListWithWords(input);
            List<string> expectedResultList = InitializeListWithWords(expectedResult);

            var test = new ListSplitSentencesToWords(inputList);

            CollectionAssert.AreEqual(expectedResultList, test.Input);
        }

        [Test()]
        public void EmptyListInputExceptionTest()
        {
            var input = new List<string>();

            Assert.Throws(typeof(EmptyTextException), () => new ListSplitSentencesToWords(input));
        }


    }
}