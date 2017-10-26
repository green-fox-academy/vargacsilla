using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class ClickCounter
    {
        public int ClickCount { get; set; }

        public void Raise()
        {
            ClickCount++;
        }
    }
}
