using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("racecar"));
            Console.WriteLine(Palindrome("Racecar"));
            Console.WriteLine(Palindrome("mM"));
            Console.WriteLine(Palindrome("p"));
            Console.WriteLine(Palindrome("Géza kék az ég"));
            Console.WriteLine();
            Console.WriteLine(AdvancedPalindrome("Géza, kék az ég!"));
            Console.ReadLine();
        }

        private static bool Palindrome(string word)
        {
            word = word.ToLower();
            for (int i = 0; i <= word.Length/2; i++)
            {
                if (word[i] != word[word.Length - i -1])
                {
                    return false;
                }
            };
            return true;
        }

        private static bool AdvancedPalindrome(string word)
        {
            word = word.ToLower()
                       .Replace(" ", string.Empty)
                       .Replace(".", string.Empty)
                       .Replace("!", string.Empty)
                       .Replace("?", string.Empty)
                       .Replace(",", string.Empty);
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            };
            return true;
        }
    }
}
