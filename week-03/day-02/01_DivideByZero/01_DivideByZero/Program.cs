using System;

namespace _01_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideTen(GetInputNum());
            Console.Read();
        }

        private static void DivideTen(int userNum)
        {
            try
            {
                int result = 10 / userNum;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }

        }

        private static int GetInputNum()
        {
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
