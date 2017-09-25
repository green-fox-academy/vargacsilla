using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static Random RandomValue = new Random();

        static void Main(string[] args)
        {
            Dice dices = new Dice() { };
            int[] rolledDices = dices.Roll(RandomValue);

            foreach (var dice in rolledDices)
            {
                Console.Write(dice + " ");
            }
            Console.Read();
        }
    }
}
