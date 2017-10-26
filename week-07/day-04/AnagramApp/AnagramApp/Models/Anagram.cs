using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramApp.Models
{
    public class Anagram
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public bool IsAnagram()
        {
            char[] word1CharArray = Word1.ToLower().ToCharArray();
            char[] word2CharArray = Word2.ToLower().ToCharArray();

            Array.Sort(word1CharArray);
            Array.Sort(word2CharArray);

            return new string(word1CharArray) == new string(word2CharArray);
        }
    }
}
