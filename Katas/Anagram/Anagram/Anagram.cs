using System.Collections.Generic;

namespace Katas {
    public class Anagram {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");
        }

        public List<string> GenerateAnagrams(string inputWord) {
            if (inputWord.Equals("")) {
                return new List<string>();
            }
            return new List<string> { inputWord };

            //todo: load word list
            //generate anagrams
            //clean up code
        }
    }
}
