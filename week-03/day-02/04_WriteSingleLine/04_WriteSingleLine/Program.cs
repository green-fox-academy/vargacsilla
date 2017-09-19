using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./../../my-file.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Varga Csilla");
                }
            }
            catch
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}

