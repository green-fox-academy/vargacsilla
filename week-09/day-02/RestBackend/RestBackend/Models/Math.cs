using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestBackend.Models
{
    public class Math
    {
        public int Sum(int number)
        {
            int result = 0;
            for (int i = number; i > 0; i--)
            {
                result += i;
            }
            return result;
        }

        public int Factor(int number)
        {
            int result = number;
            for (int i = number - 1; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

    }
}
