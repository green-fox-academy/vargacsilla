using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(5));
            Console.ReadLine();
        }

        public static int Factorio(int num)
        {
            for (int i = (num - 1); i >= 1 ; i--)
            {
                num *= i;
            }
            return num;
        }
    }
}
