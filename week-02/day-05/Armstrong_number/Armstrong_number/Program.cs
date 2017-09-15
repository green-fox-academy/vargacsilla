using System;
using System.Collections.Generic;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // get number
            int userNum = GetNumber();
            // check if its armstrong
            bool isArmstrong = IsItArmstrongNumber(userNum);
            //// split number to digits
            //// raise every digit to the nth power
            //// add numbers together

            Console.WriteLine(isArmstrong);
            Console.ReadLine();
        }

        public static int GetNumber()
        {
            int getNumber = int.Parse(Console.ReadLine());
            return getNumber;
        }
    }
}
