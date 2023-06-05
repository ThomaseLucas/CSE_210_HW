using System.Collections.Generic;
using System;


namespace Develop03
{
    public class Scripture
    {
        public List<Word> _scripturewords;
        private string _sacredtext = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        //change to private ^^
        private bool[] _hiddenword = {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false};
        public Reference Reference { get; set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            _scripturewords = new List<Word>();
            LoadScripture(text);
        }

        public int GetTextLength()
        {
            string[] arrayOfWords = _sacredtext.Split();
            return arrayOfWords.Length;
        }
        public string GetSacredText()
        {
            string SacredText = _sacredtext;
            return SacredText;
        }
        private void LoadScripture(string text)
        {
            string[] arrayOfWords = text.Split();
            foreach (string word in arrayOfWords)
            {
                Word newWord = new Word{_scriptureText = word};
                _scripturewords.Add(newWord);
                
            }
        }

        public string HideRandomWords()
        {
            Random random = new Random();
            int numWordsToHide = Math.Min(3, _scripturewords.Count);
    
            // Create a list to store the indices of the words to be hidden
            List<int> hiddenIndices = new List<int>();

            // Randomly select and add unique indices to the hiddenIndices list
            while (hiddenIndices.Count < numWordsToHide)
            {
                int randomIndex = random.Next(0, _scripturewords.Count);
        
                // Check if the index is already in the hiddenIndices list
                if (!hiddenIndices.Contains(randomIndex))
                {
                    hiddenIndices.Add(randomIndex);
                    _hiddenword[randomIndex] = true; // Set the corresponding hidden word flag to true
                }
            }

            string result = " ";
            for (int i = 0; i < _scripturewords.Count; i++)
            {
                if (_hiddenword[i] == true)
                {
                    result += "______" + " ";
                }
                else
                {
                    result += _scripturewords[i]._scriptureText + " ";
                }
            }

            return result;
        }    
    }
}

