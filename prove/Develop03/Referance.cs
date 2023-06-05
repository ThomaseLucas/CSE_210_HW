using System;

namespace Develop03
{
    public class Reference
    {
        public string Book = "John";
        public string Chapter = "3";
        public string VerseStart = "16";
        public string VerseEnd {get; set;}

        public string FormatReference()
        {
            if (VerseEnd != null)
                return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
            else
                return $"{Book} {Chapter}:{VerseStart}";
        }
    }
}