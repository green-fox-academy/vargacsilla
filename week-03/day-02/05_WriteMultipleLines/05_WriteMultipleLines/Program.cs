using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file.

namespace _05_WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteWordsAndLines("./../../testText.txt", "apples", 5);
        }

        private static void WriteWordsAndLines(string path, string word, int lines)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < lines; i++)
                    {
                        sw.WriteLine(word);
                    }
                }
            }
            catch
            {
                Console.WriteLine("I could not write the file.");
            }
        }
    }
}
