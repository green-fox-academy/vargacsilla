using System;

namespace exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidRows = 10;
            string pyr = "*";
            int spaceNum = pyramidRows - 1;

            for (int i = 0; i < pyramidRows; i++)
            {
                for (int j = spaceNum; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                spaceNum -= 1;
                Console.WriteLine(pyr);
                pyr += "**";
            }
            Console.ReadLine();
        }
    }
}
