using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var aICities = from city in cities
                           where city.First() == 'A' && city.Last() == 'I'
                           select city;

            foreach (var item in aICities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
