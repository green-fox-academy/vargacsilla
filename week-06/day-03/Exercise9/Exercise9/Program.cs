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
            char[] myCharArray = { 'c', 's', 'i', 'L', 'l', 'A' };

            var myString = string.Join("", myCharArray.Select(x => x));

            Console.WriteLine(myString);
            Console.Read();
        }
    }
}
