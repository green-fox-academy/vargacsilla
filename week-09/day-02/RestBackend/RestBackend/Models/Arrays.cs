using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestBackend.Models
{
    public class Arrays
    {
        public Math? What { get; set; }
        public int[] Numbers;

        public int Sum()
        {
            int result = 0;
            foreach (var number in Numbers)
            {
                result += number;
            }
            return result;
        }

        public int Multiply()
        {
            int result = Numbers[0];
            for (int i = 1; i <= Numbers.Length; i++)
            {
                result *= Numbers[i];
            }
            return result;
        }

        public int[] Double()
        {
            var resultNumberArray = Numbers.Select(number => number * 2);
            return (int[])resultNumberArray;
        }
    }
}
