using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringsAgainAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            string s = "AXxBXxCXx";
            Console.WriteLine(SwapXToY(s));
            Console.ReadLine();
        }

        private static string SwapXToY(string s)
        {
            if (s.Length == 1)
                return s;
            else
                return s = s[0] + "*" + SwapXToY(s.Substring(1));

        }
    }
}
