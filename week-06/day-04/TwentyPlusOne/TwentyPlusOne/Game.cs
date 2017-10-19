using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        public Deck myDeck = new Deck();
        public List<Card> cardsInHand = new List<Card>();
        Random random = new Random();

        public int myScore;
        int opponentScore;

        public Game()
        {
            myDeck.FillDeck();
            GenerateOpponentScore();
            myScore = 0;
        }

        public void StartGame()
        {
            Console.WriteLine($"Opponent's score: {opponentScore}");
            Console.WriteLine($"Your current score is: {myScore}");
            Console.WriteLine("Would you like to draw another card? [ENTER / X]");
            Console.WriteLine();

            while (Console.ReadKey().Key == ConsoleKey.Enter && myScore < 21)
            {
                Card drawnCard = myDeck.PullRandom();
                EvaluateCard(drawnCard);
                Console.WriteLine($"You have drawn a [{drawnCard.suit} {drawnCard.rank}]");
                Console.WriteLine($"Your current score is: {myScore}");
                Console.WriteLine();
                Console.WriteLine("Would you like to draw another card? [ENTER / X]");
                Console.WriteLine();
            }
            if (myScore >= 21)
            {
                Console.WriteLine("Game over.");
            }
            else
            {
                Console.WriteLine("You quit the game, we dont know yet who won.");
            }
            Console.Read();
        }

        public void EvaluateCard(Card drawnCard)
        {
            if (drawnCard.rank < (CardRank)10)
            {
                myScore += (int)drawnCard.rank;
            }
            else if (drawnCard.rank >= (CardRank)10 && drawnCard.rank < (CardRank)14)
            {
                myScore += 10;
            }
            else if (drawnCard.rank == (CardRank)14 && myScore <= 10)
            {
                myScore += 11;
            }
            else
            {
                myScore += 1;
            }
        }

        public void GenerateOpponentScore()
        {
            opponentScore = random.Next(14, 22);
        }


    }
}
