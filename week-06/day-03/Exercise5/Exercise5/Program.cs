using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyDictionary = from num in n
                                      group num by num into nums
                                      select new { nums.Key, count = nums.Count() };

            //Dictionary<int, int> frequencyDictionary = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in frequencyDictionary)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
