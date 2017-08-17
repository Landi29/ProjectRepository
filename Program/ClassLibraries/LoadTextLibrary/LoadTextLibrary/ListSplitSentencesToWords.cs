using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTextLibrary
{
    public class ListSplitSentencesToWords
    {
        public List<string> Input { get; private set; } = new List<string>();
        public List<string> Result { get; private set; } = new List<string>();
        public string[] TempWords { get; private set; }


        public ListSplitSentencesToWords(List<string> input)
        {
            this.Input = input;

            SplitSentencesTOWords();
        }

        public void SplitSentencesTOWords()
        {
            if (!Input.Any())
                throw new EmptyTextException("The given text is empty");

            foreach(string Sentence in Input)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-", "\\", "(", ")", "/" };

                TempWords = Sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                InsertWordsToList();
            }
        }

        public void InsertWordsToList()
        {
            foreach (string Word in TempWords)
                Result.Add(Word);
        }


    }
}
