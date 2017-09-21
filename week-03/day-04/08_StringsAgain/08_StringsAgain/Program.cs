using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            string s = "AXxBXxCXx";
            Console.WriteLine(DeleteX(s));
            Console.ReadLine();
        }

        private static string DeleteX(string s)
        {
            if (s.Length == 0)
                return s;
            else if (s[0] == 'x')
            {
                return s = DeleteX(s.Substring(1));
            }
            else
                return s = s[0] + DeleteX(s.Substring(1));

        }
    }
}
