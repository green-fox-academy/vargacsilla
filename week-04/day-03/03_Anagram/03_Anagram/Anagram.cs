using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Anagram
{
    public class MyClass
    {
        public bool IsAnagram(string firstWord, string secondWord)
        {
            char[] firstChars = firstWord.ToCharArray();
            char[] secondChars = secondWord.ToCharArray();

            Array.Sort(firstChars);
            Array.Sort(secondChars);

            string first = new string(firstChars).ToLower();
            string second = new string(secondChars).ToLower();

            return first == second;
        }
    }
}
