using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "VaArga csillA";

            var charCount = from character in testString.ToLower()
                            group character by character into uniqueCharacters
                            select new { uniqueCharacters.Key, Value = uniqueCharacters.Count() };

            //var charCount = testString.ToLower().GroupBy(letter => letter).ToDictionary(letter => letter.Key, letter => letter.Count()).OrderBy(letter => letter.Key);

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.Read();
        }
    }
}
