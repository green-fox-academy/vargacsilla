using System;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int allSeconds = 24 * 60 * 60;

            Console.WriteLine("One day is {0} seconds long.", allSeconds);
            int remainingSeconds = allSeconds - ((currentHours * 60 * 60) + (currentMinutes * 60) + currentSeconds);
            Console.WriteLine("The current time is {0}:{1}:{2} - this means there are {3} seconds left of the day.", 
                currentHours, currentMinutes, currentSeconds, remainingSeconds);
            Console.ReadLine();
        }
    }
}
