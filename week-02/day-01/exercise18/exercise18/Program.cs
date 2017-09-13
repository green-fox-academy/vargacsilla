using System;

namespace exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me a number!");
            int userNum;

            while (!(int.TryParse(Console.ReadLine(), out userNum)))
            {
                Console.WriteLine("That's not an integer number, please try again!");
            }   

            if (userNum % 2 == 0)
                Console.WriteLine("That's an even number.");
            else
                Console.WriteLine("That's an odd number.");

            Console.ReadLine();
        }
    }
}
