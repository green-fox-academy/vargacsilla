using System;

namespace exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("I'll draw you a triangle, if you tell me how many lines tall you want it to be. Give me a number!");
            int triangleLines = int.Parse(Console.ReadLine());

            for (int i = 0; i <= triangleLines; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
