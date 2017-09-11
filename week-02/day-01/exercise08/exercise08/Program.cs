using System;

namespace exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the wariables
            int a = 123;
            int b = 526;
            int tempA = a;
            a = b;
            b = tempA;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();
        }
    }
}
