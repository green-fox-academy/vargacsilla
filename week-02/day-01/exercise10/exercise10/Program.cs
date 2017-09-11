using System;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable than print their values
            // Your name as a string
            string myName = "Csicsi";
            // Your age as an integer
            int myAge = 26;
            // Your height in meters as a double
            double myHeight = 1.75;
            // Wether you are married or not as a boolean
            bool married = false;
            Console.WriteLine("I am" + myName + ".");
            Console.WriteLine("I am " + myAge + " years old.");
            Console.WriteLine("I am " + myHeight + " meters tall.");
            Console.WriteLine("Am I married?" + married + ".");
            Console.ReadLine();
        }
    }
}
