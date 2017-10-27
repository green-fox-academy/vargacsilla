
namespace TwentyPlusOne
{
    class Card
    {
        public CardColor Color { get; set; }
        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }

        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
