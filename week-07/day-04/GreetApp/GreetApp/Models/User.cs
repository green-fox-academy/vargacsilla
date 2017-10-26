using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetApp.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Greet()
        {
            return $"Hello, dear {Name}!";
        }
    }
}
