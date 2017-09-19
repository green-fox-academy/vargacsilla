using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyTo(@"./../../testOriginal.txt", @"./../../testCopy.txt");
            Console.Read();
        }

        private static void CopyTo(string originalFile, string copyFile)
        {

            bool success = true;
            try
            {
                    string[] content = File.ReadAllLines(originalFile);
                    File.WriteAllLines(copyFile, content);
            }
            catch
            {
                success = false;
            }
            finally
            {
                Console.WriteLine(success);
            }
        }
    }
}
