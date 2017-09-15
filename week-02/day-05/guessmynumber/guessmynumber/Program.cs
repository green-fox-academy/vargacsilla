using System;

namespace guessmynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! How big should be the range?");
            int range = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int theNumber = rnd.Next(range);
            int lives = 10;

            Console.WriteLine("Okay, now guess a number!");
            int guess;

            for (int i = lives; i > 0; lives--)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess > theNumber)
                    Console.WriteLine("Too high. You have {0} lives left.", lives - 1);
                if (guess < theNumber)
                    Console.WriteLine("Too low. You have {0} lives left.", lives - 1);
                if (guess == theNumber)
                    Console.WriteLine("Congrats, you won!");
            }

            Console.WriteLine(theNumber);
            Console.ReadLine();
        }
    }
}
