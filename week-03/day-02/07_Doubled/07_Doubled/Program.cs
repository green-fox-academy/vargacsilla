using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07_Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./../../../../duplicated-chars.txt";
            string newPath = @"./../../../../deduplicated-chars.txt";
            // To modify original file:
            // DeDuplicate(path);
            DeDuplicate(path, newPath);
        }

        // To modify original file:
        // private static void DeDuplicate(string path)
        private static void DeDuplicate(string path, string newPath)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j ++)
                {
                    lines[i] = lines[i].Remove(j, 1);
                }
                File.WriteAllLines(newPath, lines);
            }
        }
    }
}
