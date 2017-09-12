using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            Console.WriteLine(AppendA(am));
            Console.ReadLine();
        }

        private static string AppendA(string text)
        {
            return text += "a";
        }
    }
}
