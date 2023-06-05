using System.Collections.Generic;
using System;


namespace Develop03
{
    public class Scripture
    {
        public List<Word> _scripturewords;
        private List<Word> _hiddenWords;
        private string _sacredtext = "For God so loved the world that he gave his only son";
        //change to private ^^
        private bool[] _hiddenword = {false, false, false, false, false, false, false, false, false, false, false, false};
        public Reference Reference { get; set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            _scripturewords = new List<Word>();
            _hiddenWords = new List<Word>();
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
                _scripturewords.Add(new Word {_scriptureText = word, _isHidden = false});
            
            }
        }

        public string HideRandomWords()
        {
            Random random = new Random();
            int numWordsToHide = Math.Min(3, GetTextLength());
            for (int i = 0; i < numWordsToHide; i++)
            {
                bool loop = true;
                while (loop)
                {
                    
                    int random_int = random.Next(0, GetTextLength());
                    //provides a random integer to take away from the list of words in this loop
                    string random_word = _scripturewords[random_int]._scriptureText;

                    bool hidden = _hiddenWords[random_int]._isHidden;

                    if (!_hiddenWords[random_int]._isHidden)
                    //setting hiddenWord to true, changes boolean from false to true
                    {
                        _hiddenWords[random_int]._isHidden = true;
                    }
                    bool allHidden = true;
                    //If all of them = true, the loop will exit the program, if not it will break
                    for (int j = 0; j < GetTextLength(); j++)
                    {
                        if (!_hiddenWords[i]._isHidden)
                        {
                            allHidden = false;
                            break;
                        }
                        if (allHidden)
                        {
                            Environment.Exit(0);
                        }
                    }



                }
            }
            string result = " ";
            for (int i = 0; i < GetTextLength(); i++)
            {
                if (_hiddenWords[i]._isHidden == true)
                {
                    result += "______" + " ";
                }
                else
                {
                    result += _scripturewords[i] + " ";
                }

        
            }
            return result;    
        }
    }
}
