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

        private static bool IsItArmstrongNumber(int inputNum)
        {
            bool isArmstrong;
            List<int> digitsList = new List<int>();

            digitsList = SplitToDigits(inputNum);


        
            return isArmstrong;
        }

        private static List<int> SplitToDigits(int inputNum)
        {
            List<int> digits = new List<int>();

            for (int i = 0; inputNum >= 0; i++)
            {
                digits[i] = inputNum % 10;
                inputNum = inputNum / 10;
            };

            digits.Reverse();

            return digits;
        }

        public static int GetNumber()
        {
            int getNumber = int.Parse(Console.ReadLine());
            return getNumber;
        }
    }
}
