using System;

namespace exercise17
{
    class Program
    {
        private static int first;

        static void Main(string[] args)
        {
            Console.WriteLine("Give me 5 numbers (after each number press Enter)!");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int fifth = int.Parse(Console.ReadLine());

            int sum = first + second + third + fourth + fifth;
            int average = sum / 5;

            Console.WriteLine("Sum: {0}, Average: {1}", sum, average);
            Console.ReadLine();
        }
    }
}
