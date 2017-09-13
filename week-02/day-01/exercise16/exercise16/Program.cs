using System;

namespace exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens are there on the farm?");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many pigs?");
            int pigs = int.Parse(Console.ReadLine());
            Console.WriteLine("The chickens and the pigs together have {0} legs.", (chickens * 2) + (pigs * 4));
            Console.ReadLine();
        }
    }
}
