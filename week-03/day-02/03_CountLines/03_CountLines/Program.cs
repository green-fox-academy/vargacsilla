using System;
using System.IO;

namespace _03_CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLines(@"C:\Users\Csilla\greenfox\vargacsilla\week-03\day-02\02_PrintEachLine\02_PrintEachLine\Program.cs"));
            Console.Read();
        }

        private static int NumberOfLines(string path)
        {
            int numberOfLines = 0;
            try
            {
                string[] allLines = File.ReadAllLines(path);
                numberOfLines = allLines.Length;
            }
            catch
            {
                numberOfLines = 0;
            }
            return numberOfLines;
        }
    }
}
