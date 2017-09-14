using System;

namespace exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Give me two numbers!");
            string userInput = Console.ReadLine();
            string[] userInputs = userInput.Split(' ');
            int firstNum = int.Parse(userInputs[0]);
            int secondNum = int.Parse(userInputs[1]);
            Console.WriteLine();

            if (firstNum >= secondNum)
                Console.WriteLine("The second number should be bigger.");
            else
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
