using System;

namespace exercise35
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;


            for (int i = 0; i < width; i++)
            {
                int startNum;

                if (i % 2 == 0)
                    startNum = 1;
                else
                    startNum = 0;
                
                for (int j = startNum; j < width; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(" ");
                    else
                        Console.Write("%");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
