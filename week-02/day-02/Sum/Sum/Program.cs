using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5));
            Console.ReadLine();
        }

        private static int Sum(int number)
        {
            int numSum = 0; 
            for (int i = 1; i <= number; i++)
            {
                numSum += i;
            }
            number = numSum;
            return number;
        }
    }
}
