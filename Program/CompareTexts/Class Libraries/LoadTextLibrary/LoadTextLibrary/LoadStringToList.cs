using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoadTextLibrary
{
    public class LoadStringToList : LoadTextFromFile
    {  
        public List<string> Lines { get; private set; } = new List<string>(); // Contains the loaded lines from the text
        public int LinesInText { get; private set; } // Contains the amount of lines in the text
        public int CharsInText { get; private set; } // Contains the total amount of letters and digits in the text 

        public LoadStringToList(string filePath) : base(filePath)
        {
            this.LoadText();

            GetAmountOfChars();
        }

        public override void LoadText() // Loads the text 
        {
            Lines = File.ReadLines(FilePath).ToList();  // Loads each line in the txt file and adds them to a list
      
            for (int i = Lines.Count - 1; i >= 0; --i) // Goes through the list from top to bottom
            {
                if (string.IsNullOrWhiteSpace(Lines[i])) // Happens if the string is empty
                {
                    Lines.RemoveAt(i);
                }
            }

            LinesInText = Lines.Count(); // Counts the amount of lines in the text

            if (LinesInText == 0) // Happens if the list is empty
                throw new EmptyTextException("The txt file is empty"); 
        }

        public string GetLine(int i) // Get the line at a given index 
        {
            if (i < 0) // Happens if the index is negative 
                throw new IndexOutOfRangeException("The given index cannot be negative");
            if (i > LinesInText - 1) // Happens if the given index is larger than the amount of lines in the text
                throw new IndexOutOfRangeException("The given index exceeds the number of words in the given text");

            return Lines[i];
        }

        public void GetAmountOfChars() // Counts the total amount of chars in the text
        {
            int amountChars = 0; 

            foreach(string i in Lines) // Goes through every line in the text
            {
                amountChars += CountChars(i);
            }

            CharsInText = amountChars;
        }

        public int CountChars(string currentString) // Counts the amount of chars in a string
        {
            int charsInString = 0;

            foreach(char i in currentString) // Goes through every char in the string
            {
                if(char.IsLetterOrDigit(i)) // happens if the char is a letter or digit 
                    ++charsInString;
            }

            return charsInString;
        }

    }
}
