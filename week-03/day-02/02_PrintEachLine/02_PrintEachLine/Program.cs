// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"


using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                string[] allLines = File.ReadAllLines(path);
                foreach (string line in allLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            Console.Read();
        }
    }
}


