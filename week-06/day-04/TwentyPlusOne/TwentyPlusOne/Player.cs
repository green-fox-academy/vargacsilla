using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Player
    {
        public List<Card> cards = new List<Card>();
        public int Score { get; set; }
        public string Name { get; set; }

        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }
    }
}
