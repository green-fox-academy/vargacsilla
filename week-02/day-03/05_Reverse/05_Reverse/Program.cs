using System;
using System.Text;

namespace _05_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            reversed = Reverse(reversed);
            Console.WriteLine(reversed);
            Console.ReadLine();
        }

        public static string Reverse(string reverseString)
        {
            string rightOrder = "";
            for (int i = (reverseString.Length - 1); i >= 0; i--)
            {
                rightOrder += reverseString[i];
            }
            return rightOrder;


        }
    }
}
