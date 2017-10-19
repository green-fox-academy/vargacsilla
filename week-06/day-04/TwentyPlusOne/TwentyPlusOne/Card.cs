using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Card
    {
        public CardColor color;
        public CardSuit suit;
        public CardRank rank;

        public Card(CardSuit suit, CardRank rank)
        {
            this.suit = suit;

            if (suit == CardSuit.hearts || suit == CardSuit.diamonds)
            {
                color = CardColor.red;
            }
            else color = CardColor.black;

            this.rank = rank;
        }
    }
}
