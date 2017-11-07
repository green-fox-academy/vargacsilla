using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestBackend.Models
{
    public class Number
    {
        public int? Until { get; set; }

        public int Sum()
        {
            int result = 0;
            for (int i = (int)Until; i > 0; i--)
            {
                result += i;
            }
            return result;
        }

        public int Factor()
        {
            int result = (int)Until;
            for (int i = (int)Until - 1; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
