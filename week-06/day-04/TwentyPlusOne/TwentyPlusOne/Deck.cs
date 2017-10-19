using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        Random random = new Random();

        public List<Card> cardList = new List<Card>();

        public void FillDeck()
        {
            for (int i = 0; i < typeof(CardSuit).GetEnumNames().Count(); i++)
            {
                for (int j = 0; j < typeof(CardRank).GetEnumNames().Count(); j++)
                {
                    cardList.Add(new Card((CardSuit)i, (CardRank)j));
                }
            }
        }

        public void ShuffleDeck()
        {
            for (int i = 0; i < cardList.Count(); i++)
            {
                Card temp = cardList[i];
                int swapIndex = random.Next(cardList.Count());
                cardList[i] = cardList[swapIndex];
                cardList[swapIndex] = temp;
            }
        }

        public Card PullFirst()
        {
            var drawnCard = cardList[0];
            cardList.RemoveAt(0);
            return drawnCard;
        }

        public Card PullLast()
        {
            var drawnCard = cardList[cardList.Count() - 1];
            cardList.RemoveAt(cardList.Count() - 1);
            return drawnCard;
        }

        public Card PullRandom()
        {
            int drawnIndex = random.Next(cardList.Count());
            var drawnCard = cardList[drawnIndex];
            cardList.RemoveAt(drawnIndex);
            return drawnCard;
        }
    }
}
