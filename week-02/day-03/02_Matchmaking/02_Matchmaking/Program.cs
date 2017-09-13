using System;
using System.Collections.Generic;

namespace _02_Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < boys.Count; i++)
            {
                if (i <girls.Count)
                {
                order.Add(girls[i]);
                }
                order.Add(boys[i]);
            }

            foreach (var names in order)
            {
                Console.Write("{0} ", names);
            }
            Console.ReadLine();
        }
    }
}