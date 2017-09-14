using System;

namespace exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square side:");
            int squareSide = int.Parse(Console.ReadLine());

            for (int j = 0; j < squareSide; j++) // Első sor
            {
                Console.Write("%");
            }
            Console.WriteLine();

            for (int k = 0; k < squareSide -2; k++) // minden közbenső sor
            {
                Console.Write("%");

                for (int j = 0; j < squareSide - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("%");
            }

            for (int j = 0; j < squareSide; j++) // Utolsó sor
            {
                Console.Write("%");
            }

            Console.ReadLine();
        }
    }
}
