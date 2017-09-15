using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word!");
            string wordInput = Console.ReadLine();
            Console.WriteLine(Palindrome(wordInput));
            Console.ReadLine();
        }

        public static string Palindrome(string word)
        {
            string palindromeWord = word;
            for (int i = 0; i < word.Length; i++)
            {
                palindromeWord += word[word.Length - i - 1];
            }
            return palindromeWord;
        }
    }
}
