using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxList = new List<Fox>();
            foxList.Add(new Fox("Rudi", "pallida", ConsoleColor.Green));
            foxList.Add(new Fox("Vuk", "forest", ConsoleColor.Green));
            foxList.Add(new Fox("Vori", "desert", ConsoleColor.Red));
            foxList.Add(new Fox("Mazli", "arctic", ConsoleColor.White));
            foxList.Add(new Fox("Csicsi", "pallida", ConsoleColor.Green));

            //var greenFoxes = from fox in foxList
            //                 where fox.Color == ConsoleColor.Green
            //                 select fox;

            var greenFoxes = foxList.Where(fox => fox.Color == ConsoleColor.Green).Select(fox => fox).ToList();

            foreach (var item in greenFoxes)
            {
                Console.WriteLine(item.Name);
            }

            var greenPallidaFoxes = (foxList.Where(fox => (fox.Color == ConsoleColor.Green) && (fox.Type == "pallida"))).Select(fox => fox).ToList();

            Console.WriteLine();
            foreach (var item in greenPallidaFoxes)
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }
    }
}
