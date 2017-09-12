using System;

namespace exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 100;
            int userNum;
            Console.WriteLine("Guess a number!");

            do
            {
                userNum = int.Parse(Console.ReadLine());
                if (userNum < myNum)
                {
                    Console.WriteLine("The stored number is higher.");
                }
                else if (userNum > myNum)
                {
                    Console.WriteLine("The stored number is lower.");
                }
                else
                {
                Console.WriteLine("You found the number! It's {0}.", myNum);
                }
            }
            while (userNum != myNum);
            Console.ReadLine();
        }
    }
}
