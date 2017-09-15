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
            int lives = 6;

            Console.WriteLine("Okay, now guess a number!");
            int guess;
            bool didWin = false;

            bool isGameOn = true; 

            while (isGameOn)
            {
                guess = int.Parse(Console.ReadLine());
                isGameOn = lives > 0 && didWin == false;
                if (guess > theNumber)
                {
                    Console.WriteLine("Too high. You have {0} lives left.", lives);
                    lives--;
                }
                if (guess < theNumber)
                {
                    Console.WriteLine("Too low. You have {0} lives left.", lives);
                    lives--;
                }
                if (guess == theNumber)
                {
                    didWin = true;
                }
            }

            if (didWin)
               Console.WriteLine("Congrats, you won!");
            if (!didWin)
                Console.WriteLine("Game over. The number was: {0}", theNumber);

            Console.ReadLine();
        }
    }
}
