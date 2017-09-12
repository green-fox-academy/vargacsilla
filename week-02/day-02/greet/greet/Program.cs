using System;

namespace greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            greet(al);
            Console.ReadLine();
        }

        private static void greet(string name)
        {
            Console.WriteLine("Greetings, dear {0}!", name);
        }
    }
}
