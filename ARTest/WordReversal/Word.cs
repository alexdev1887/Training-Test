using ARTest.WordReversal.Base;
using System;
using System.Linq;

namespace ARTest.WordReversal
{
    internal class Word : WordBase
    {
        private string ReversedWord { get; set; }
        public Word(string word)
        {
            ReversedWord = ReverseWord(word);
        }

        internal string ReverseWord(string word) 
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string result = new string(wordArray);

            return result;
        }

        internal override void ProcessingWord()
        {
            Console.WriteLine($"Parola rovesciata: {ReversedWord}");
            base.ProcessingWord();
        }
    }
}
