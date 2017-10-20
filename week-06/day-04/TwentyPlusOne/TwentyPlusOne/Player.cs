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
        public string Name { get; set; }
        public int Score
        {
            get
            {
                return CountScore();
            }
        }

        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }

        private int CountScore()
        {
            int score = 0;
            var sortedCards = from card in cards
                              orderby card.rank ascending
                              select card;

            foreach (var card in sortedCards)
            {
                score += GetCardScore(card);
            }
            return score;
        }

        public int GetCardScore(Card drawnCard)
        {
            int cardScore = (int)drawnCard.rank + 2;                                //TODO: ezt szebb lenne a cardRank-ben lekezelni

            if (drawnCard.rank >= (CardRank)8 && drawnCard.rank < (CardRank)12)
            {
                cardScore = 10;
            }
            else if (drawnCard.rank == (CardRank)12 && Score <= 10)              
            {
                cardScore = 11;
            }
            else if (drawnCard.rank == (CardRank)12 && Score > 10)
            {
                cardScore = 1;
            }
            return cardScore;
        }
    }
}
