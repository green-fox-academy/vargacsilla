using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            List<int[]> sortedDominoes = new List<int[]>();
            sortedDominoes = SortDominoes(dominoes);

            foreach (var domino in sortedDominoes)
            {
                Console.Write("[" + domino[0] + " " + domino[1] + "] ");
            }
           
            Console.ReadLine();

        }

        private static List<int[]> SortDominoes(List<Domino> dominoes)
        {
            List<int[]> sortedDominoes = new List<int[]> { };
            sortedDominoes.Add(dominoes[0].GetValues());
            dominoes.RemoveAt(0);

            for (int i = 0; dominoes.Count > 0; i++)
            {                             
                if (sortedDominoes[sortedDominoes.Count - 1][1] == dominoes[i].GetValues()[0])
                {
                    sortedDominoes.Add(dominoes[i].GetValues());
                    dominoes.RemoveAt(i);
                    i = -1;
                }
            }
            return sortedDominoes;
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}