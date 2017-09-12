using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer("valami", "masvalami", "barmi", "vegtelen", "szavak", "huhuuu");
			Console.ReadLine();
        }

        public static void Printer(params string[] words)
        {
            foreach (string word in words)
            {
                Console.Write("{0}, ", word);
            }
        }
    }
}
