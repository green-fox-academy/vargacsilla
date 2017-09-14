using System;

namespace exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
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
