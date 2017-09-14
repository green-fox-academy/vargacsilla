using System;

namespace exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square side:");
            int squareSide = int.Parse(Console.ReadLine());

            for (int i = 0; i < squareSide; i++) // Első sor
            {
                Console.Write("%");
            }
            Console.WriteLine();

            for (int i = 0; i < squareSide - 2; i++) // minden közbenső sor
            {
                Console.Write("%");

                for (int j = 0; j < squareSide - 2; j++)
                {
                    if (j == i)
                        Console.Write("%");
                    else
                    Console.Write(" ");
                }

                Console.WriteLine("%");
            }

            for (int i = 0; i < squareSide; i++) // Utolsó sor
            {
                Console.Write("%");
            }

            Console.ReadLine();
        }
    }
}
