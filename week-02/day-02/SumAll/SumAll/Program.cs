using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            int sumAll = 0;
            foreach (var item in ai)
            {
                sumAll += item;
            }
            Console.WriteLine(sumAll);
            Console.ReadLine();
        }
    }
}