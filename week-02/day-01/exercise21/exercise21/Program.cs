using System;

namespace exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBoys;
            int numGirls;

            Console.WriteLine("How many girls and boys came to the party? Type a number and press Enter.");
            numGirls = int.Parse(Console.ReadLine());
            numBoys = int.Parse(Console.ReadLine());

            int numAll = numGirls + numBoys;

            if (numAll > 20 && numGirls == numBoys)
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (numAll > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (numAll < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (numGirls == 0)
            {
                Console.WriteLine("Sausage party...");
            }
            Console.ReadLine();
        }
    }
}
