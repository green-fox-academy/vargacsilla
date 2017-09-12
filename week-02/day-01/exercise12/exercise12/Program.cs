using System;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 10.1;
            double height = 20.2;
            double length = 50.3;

            Console.WriteLine("Surface Area: " + calculateSurface(width, height, length));
            Console.WriteLine("Volume: " + calculateVolume(width, height, length));

            Console.ReadLine();
        }

        public static double calculateVolume (double width, double height, double length)
        {
            double volume = width * height * length;
            return volume;
        }

        public static double calculateSurface(double width, double height, double length)
        {
            double surface = 2 * ((width * height) + (height * length) + (length * width));
            return surface;

        }
    }
}
