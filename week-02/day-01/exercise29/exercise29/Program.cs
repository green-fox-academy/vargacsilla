using System;

namespace exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I'll draw a pyramid with that many lines!");
            int rowsNum = int.Parse(Console.ReadLine());

            string pyramidBody = "*";

            for (int i = rowsNum; i > 0; i--)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
            Console.WriteLine(pyramidBody);
            pyramidBody += "**";
            }
            Console.ReadLine();
        }
    }
}
