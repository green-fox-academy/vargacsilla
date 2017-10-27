using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyPlusOne
{
    class Deck
    {
        Random random = new Random();
        public List<Card> CardList = new List<Card>();

        public void FillDeck()
        {
            for (int i = 0; i < typeof(CardSuit).GetEnumNames().Count(); i++)
            {
                for (int j = 0; j < typeof(CardRank).GetEnumNames().Count(); j++)
                {
                    CardList.Add(new Card((CardSuit)i, (CardRank)j));
                }
            }
        }

        public void ShuffleDeck()
        {
            for (int i = 0; i < CardList.Count(); i++)
            {
                Card temp = CardList[i];
                int swapIndex = random.Next(CardList.Count());
                CardList[i] = CardList[swapIndex];
                CardList[swapIndex] = temp;
            }
        }

        public Card Pull()
        {
            var drawnCard = CardList[0];
            CardList.RemoveAt(0);
            return drawnCard;
        }
    }
}
