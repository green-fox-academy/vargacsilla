using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        Random random = new Random();
        int startingCardNumber = 2;

        public Deck myDeck = new Deck();
        //public List<Player> players = new List<Player>();
        Player Player = new Player();
        Player Dealer = new Player();
        

        public Game()
        {
            myDeck.FillDeck();
            myDeck.ShuffleDeck();
            SetUpPlayers();
            PrintStatus(Dealer);
            PrintStatus(Player);
        }

        private void PrintStatus(Player player)
        {
            Console.WriteLine($"{player.Name.ToUpper()}'s score: {player.Score}");
            Console.Write("Cards: ");
            foreach (var card in player.cards)
            {
                Console.Write($"[{card.suit} - {card.rank}] ");
            }
            Console.WriteLine();
        }

        private void SetUpPlayers()
        {
            GetPlayersName();
            for (int i = 0; i < startingCardNumber; i++)
            {
                Player.cards.Add(myDeck.PullRandom());
                Player.Score += GetCardScore(Player.cards[i]);

                Dealer.cards.Add(myDeck.PullRandom());
                Dealer.Score += GetCardScore(Dealer.cards[i]);
            }
        }

        private void GetPlayersName()
        {
            Dealer.Name = "Dealer";
            Console.WriteLine("Enter your name:");
            Player.Name = Console.ReadLine();
            Console.Clear();
        }

        public void StartGame()
        {
            Console.WriteLine("Would you like to draw another card? [ENTER / X]");
            Console.WriteLine();

            while (Console.ReadKey().Key == ConsoleKey.Enter && Player.Score < 21)
            {
                Console.Clear();
                Card drawnCard = myDeck.PullFirst();
                Player.cards.Add(drawnCard);
                Player.Score += GetCardScore(drawnCard);
                Console.WriteLine($"You have drawn a [{drawnCard.suit} {drawnCard.rank}]");
                PrintStatus(Player);
                Console.WriteLine();
                Console.WriteLine("Would you like to draw another card? [ENTER / X]");
                Console.WriteLine();
            }
            if (Player.Score >= 21)
            {
                Console.WriteLine("Game over.");
            }
            else
            {
                Console.WriteLine("You quit the game, we dont know yet who won.");
            }
            Console.Read();
        }

        public int GetCardScore(Card drawnCard)
        {
            int cardScore = (int)drawnCard.rank;

            if (drawnCard.rank >= (CardRank)10 && drawnCard.rank < (CardRank)14)
            {
                cardScore = 10;
            }
            else if (drawnCard.rank == (CardRank)14 && Player.Score <= 10)              //TODO: akármelyik playerre legyen igaz!
            {
                cardScore = 11;
            }
            else if (drawnCard.rank == (CardRank)14 && Player.Score > 10)
            {
                cardScore = 1;
            }
            return cardScore;
        }
    }
}
