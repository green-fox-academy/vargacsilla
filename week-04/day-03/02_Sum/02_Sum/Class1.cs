using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sum
{
    public class MyClass
    {
        public int SumList(List<int> intList)
        {
            if (intList == null)
            {
                return 0;
            }
            else
            {
                return intList.Sum();
            }
        }
    }
}
