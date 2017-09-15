using System;
using System.Collections.Generic;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will tell you if it is an Armstrong number.");
            int userNum = GetInput();
 
            if (IsItArmstrongNumber(userNum))
                Console.WriteLine("{0} is an Armstrong number.", userNum);
            else
                Console.WriteLine("{0} is not an Armstrong number.", userNum);

            Console.ReadLine();
        }

        private static int GetInput()
        {
            int userInput = int.Parse(Console.ReadLine());

            return userInput;
        }

        private static bool IsItArmstrongNumber(int inputNum)
        {
            List<double> digitsList = new List<double> (SplitToDigits(inputNum));
            ToPowerOfCount(digitsList);
            double sumDigitsOnNth = AddListItems(digitsList);
            bool isArmstrong = sumDigitsOnNth == inputNum;

            return isArmstrong;
        }

        private static double AddListItems(List<double> digitsList)
        {
            double sumDigitsOnNth = 0;
            for (int i = 0; i < digitsList.Count; i++)
            {
                sumDigitsOnNth += digitsList[i];
            }
            return sumDigitsOnNth;
        }

        private static List<double> ToPowerOfCount(List<double> digitsList)
        {
            for (int i = 0; i < digitsList.Count; i++)
            {
                digitsList[i] = Math.Pow(digitsList[i], digitsList.Count);
            }
            return digitsList;
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
