using System;
using System.Collections.Generic;

namespace _04_CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list[1] = "Croissant";
            list[3] = "Ice Cream";

            foreach (var food in list)
            {
                Console.Write("{0}, ", food);
            }
            Console.ReadLine();
        }
    }
}