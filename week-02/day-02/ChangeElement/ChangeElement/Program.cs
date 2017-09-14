using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            // s[3] = 4;
            s.SetValue(4, 3);

            foreach (var item in s)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n" + s[3]);
            Console.ReadLine();
        }
    }
}
