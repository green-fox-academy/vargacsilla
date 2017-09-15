using System;

namespace guessmynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for range
            //get range
            Console.WriteLine("Lets play a guessing game! How big should the range be?");
            int range = int.Parse(Console.ReadLine());
            //generate a random number between 0 and range
            Random rnd = new Random();
            int theNumber = rnd.Next(range);

            Console.WriteLine(theNumber);
            Console.ReadLine();

        }
    }
}
