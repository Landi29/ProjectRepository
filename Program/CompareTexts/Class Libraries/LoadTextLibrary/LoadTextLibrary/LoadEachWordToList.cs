using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace LoadTextLibrary
{
    public class LoadEachWordToList : LoadStringToList
    {
        public List<string> Words { get; private set; } = new List<string>(); // Contains each word from the txt file
        public string[] EachWord { get; private set; }

        public LoadEachWordToList(string filePath) : base(filePath)
        { }

        public override void LoadText() // Loads the given text
        {
            base.LoadText(); // Loads each line in the text into Lines 

            foreach (string line in Lines) // Goes through each line in the text
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-", "\\", "(", ")", "/"};

                // Splits the line into seperate words, using the above standing seperators 
                EachWord = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); 

                InsertWordsToList(); // Insert each word to a list 
            }
        }

        public void InsertWordsToList()  // Insert each word to a list
        {
            foreach(string word in EachWord)
            {
                Words.Add(word);
            }
        }
        
        public string GetWord(int i) // Get the word at a given index
        {
            if (i < 0) // If the given index is negative 
                throw new IndexOutOfRangeException("The given index cannot be negative");
            if (i > Words.Count - 1) // If the given index is larger than the amount of words in the text
                throw new IndexOutOfRangeException("The given index exceeds the number of words in the given text");

            return Words[i];
        }

    }
}
