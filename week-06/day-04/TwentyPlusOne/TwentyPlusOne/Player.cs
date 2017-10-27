using System.Collections.Generic;
using System.Linq;

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
                              orderby card.Rank ascending
                              select card;

            foreach (var card in sortedCards)
            {
                score += GetCardScore(card);
            }
            return score;
        }

        public int GetCardScore(Card drawnCard)
        {
            int cardScore = (int)drawnCard.Rank + 2;

            if (drawnCard.Rank >= (CardRank)8 && drawnCard.Rank < (CardRank)12)
            {
                cardScore = 10;
            }
            else if (drawnCard.Rank == (CardRank)12 && Score <= 10)              
            {
                cardScore = 11;
            }
            else if (drawnCard.Rank == (CardRank)12 && Score > 10)
            {
                cardScore = 1;
            }
            return cardScore;
        }
    }
}
