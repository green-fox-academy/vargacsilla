using System;
using System.Collections.Generic;

namespace _07_QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            Swap(list, 2, 5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
        public static void Swap (List<string> list, int index1, int index2)
        {
            string temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        
    }
}