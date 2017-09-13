using System;

namespace exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Distance in kilometers (give me an integer): ");
            int kms = int.Parse(Console.ReadLine());
            double milePerKm = 0.621371192;
            Console.WriteLine("= {0} miles.", kms * milePerKm);
            Console.ReadLine();
        }
    }
}
