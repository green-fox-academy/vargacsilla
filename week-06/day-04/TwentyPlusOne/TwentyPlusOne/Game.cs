using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyPlusOne
{
    class Game
    {
        Random random = new Random();
        int startingCardNumber = 2;
        int maxScore = 21;
        public Deck myDeck = new Deck();
        public List<Player> playerList = new List<Player>();

        public Game()
        {
            myDeck.FillDeck();
            myDeck.ShuffleDeck();
            SetUpPlayers();
            PrintPlayerStatus(playerList[1]);
        }

        private void PrintAllStatus()
        {
            foreach (var player in playerList)
            {
                PrintPlayerStatus(player);
                Console.WriteLine();
            }
        }

        private void PrintPlayerStatus(Player player)
        {
            Console.WriteLine($"{player.Name.ToUpper()}'s score: {player.Score}");
            Console.Write("Cards: ");
            foreach (var card in player.cards)
            {
                Console.Write($"[{card.Suit} - {card.Rank}] ");
            }
            Console.WriteLine();
        }

        private void SetUpPlayers()
        {
            CreatePlayers();
            GiveCardsToPlayers();
        }

        private void GiveCardsToPlayers()
        {
            for (int i = 0; i < startingCardNumber; i++)
            {
                foreach (var player in playerList)
                {
                    player.cards.Add(myDeck.Pull());
                }
            }
        }

        private void CreatePlayers()
        {
            playerList.Add(new Player("Dealer"));

            bool addOneMorePlayer = true;
            while (addOneMorePlayer)
            {
                playerList.Add(new Player("Player"));
                addOneMorePlayer = false;
            }
        }

        private string GetPlayersName()
        {
            Console.WriteLine("Enter your name:");
            return Console.ReadLine();
        }

        public void StartGame()
        {
            Console.WriteLine($"{playerList[1].Name}, would you like to draw another card? [ENTER / X]");
            Console.WriteLine();

            while (playerList[1].Score < 21 && Console.ReadKey().Key == ConsoleKey.Enter)
            {
                GiveCardsToPlayers();

                Console.Clear();
                PrintPlayerStatus(playerList[1]);
                Console.WriteLine($"\nYou have drawn a [{playerList[1].cards.Last().Suit} {playerList[1].cards.Last().Rank}]");

                Console.WriteLine();

                Console.WriteLine("Would you like to draw another card? [ENTER / X]");
            }

            EvaluateEnding();
        }

        private void EvaluateEnding()
        {
            Console.Clear();
            if (playerList[1].Score > maxScore)
            {
                Console.Beep(2000, 1500);
                Console.WriteLine("GAME OVER.");
            }
            else if (playerList[0].Score == playerList[1].Score)
            {
                Console.WriteLine("Tie!");
            }
            else if (playerList[0].Score < playerList[1].Score)
            {
                Console.WriteLine("CONGRATS, you won!");
            }
            else
            {
                Console.WriteLine("The Dealer won.");
            }
        }
    }
}
