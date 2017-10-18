using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "vArga CSiLLa";

            //var upperChars = from chars in testString
            //                 where Char.IsUpper(chars)
            //                 select chars;

            var upperChars = testString.Where(x => Char.IsUpper(x)).Select(x => x);

            foreach (var item in upperChars)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
