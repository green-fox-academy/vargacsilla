using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = new string[] { "first", "second", "third" };
            SwapElements(abc, 0, 2);
            foreach (var item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void SwapElements(string[] array, int pos1, int pos2)
        {
            string temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }
    }
}