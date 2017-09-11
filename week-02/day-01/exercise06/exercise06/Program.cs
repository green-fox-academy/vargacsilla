using System;

namespace exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long

            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine("An average Green Fox attendee spends " + 17 * 5 * 6 + " hours with coding in a semester.");
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int codingPercentage = Convert.ToInt32((17 * 5 * 6) / (17 * 52.0) * 100);
            Console.WriteLine("This is " + codingPercentage + "% of the whole working time.");
            Console.ReadLine();
        }
    }
}
