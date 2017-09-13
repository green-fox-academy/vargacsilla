using System;
using System.Collections.Generic;

namespace _01_Solar
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };
            planetList.Insert(5, "Saturn");

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            } 

            Console.ReadLine();
        }
    }
}