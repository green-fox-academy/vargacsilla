using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDeck = new Deck();
            myDeck.FillDeck();
            Console.WriteLine(myDeck.cardList.Count());
            myDeck.ShuffleDeck();
            Console.WriteLine(myDeck.cardList.Count());

            foreach (var card in myDeck.cardList)
            {
                Console.WriteLine(card.suit + " - " + card.rank);
            }

            myDeck.PullFirst();
            Console.WriteLine();
            Console.WriteLine(myDeck.cardList.Count());
            Console.WriteLine(myDeck.cardList[0].suit + " - " + myDeck.cardList[0].rank);

            Console.Read();
        }
    }
}
