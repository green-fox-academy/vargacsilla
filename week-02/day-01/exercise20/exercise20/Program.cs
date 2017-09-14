using System;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers!");
            string input = Console.ReadLine();
            string[] userNums = input.Split(' ');
            long first = long.Parse(userNums[0]);
            long second = long.Parse(userNums[1]);

            if (first > second)
                Console.WriteLine("The bigger number is {0}.", first);
            if (first == second)
                Console.WriteLine("These numbers are equal.");
            else
                Console.WriteLine("The bigger number is {0}.", second);

            Console.ReadLine();
        }
    }
}
