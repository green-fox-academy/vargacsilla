using System;

namespace exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Give me a number! (Not too big, if possible...)");
            int numOfNums = int.Parse(Console.ReadLine());

            Console.WriteLine("Thanks! Now give {0} different numbers!", numOfNums);
            int sumOfNums = 0;

            for (int i = 0; i < numOfNums; i++)
            {
                sumOfNums += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum: {0}, Average {1}", sumOfNums, sumOfNums / numOfNums);
            Console.ReadLine();
        }
    }
}
