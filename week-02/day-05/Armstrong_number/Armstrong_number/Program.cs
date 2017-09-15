using System;
using System.Collections.Generic;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will tell you if it is an Armstrong number.");
            int userNum = int.Parse(Console.ReadLine());
 
            if (IsItArmstrongNumber(userNum))
                Console.WriteLine("{0} is an Armstrong number.", userNum);
            else
                Console.WriteLine("{0} is not an Armstrong number.", userNum);

            Console.ReadLine();
        }

        private static bool IsItArmstrongNumber(int inputNum)
        {
            List<double> digitsList = new List<double>();

            digitsList = SplitToDigits(inputNum);
 
            for (int i = 0; i < digitsList.Count; i++)
            {
                digitsList[i] = Math.Pow(digitsList[i], digitsList.Count);
            }

            double sumDigitsOnNth = 0;
            for (int i = 0; i < digitsList.Count; i++)
            {
                sumDigitsOnNth += digitsList[i];
            } 

            bool isArmstrong = sumDigitsOnNth == inputNum;

            return isArmstrong;
        }

        private static List<double> SplitToDigits(int inputNum)
        {
            List<double> digits = new List<double>();

            for (int i = 0; inputNum >= 1; i++)
            {
                digits.Add(inputNum % 10);
                inputNum = inputNum / 10;
            };

            digits.Reverse();

            return digits;
        }
    }
}
