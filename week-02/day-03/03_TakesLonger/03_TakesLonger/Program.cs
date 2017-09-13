using System;
using System.Text;

namespace _03_TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string missing = " always takes longer than";

            int breakPoint = quote.IndexOf(" you");
            string part1 = quote.Substring(0, breakPoint);
            string part2 = quote.Substring(breakPoint);
            
            StringBuilder modQuote = new StringBuilder("");
            modQuote.Append(part1).Append(missing).Append(part2);

            Console.WriteLine(modQuote);
            Console.ReadLine();
        }
    }
}
