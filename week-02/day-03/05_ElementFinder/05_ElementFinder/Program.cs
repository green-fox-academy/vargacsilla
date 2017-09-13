using System;
using System.Collections.Generic;

namespace _05_ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            //// Listname[indexNum].Equals(value)

            //bool contains = false;
            //for (int i = 0; i < List.Count; i++)
            //{
            //    if (List[i].Equals(7))
            //    {
            //        contains = true;
            //    }
            //}
            //if (contains == true)
            //{
            //Console.WriteLine("Hoorray, there's a 7 in the list!");
            //}
            //else
            //{
            //Console.WriteLine("Nooo, no 7 in the list!");
            //}

            // listname.Contains(itemToLookFor)

            if (List.Contains(7))
            {
                Console.WriteLine("Hoorray, there's a 7 in the list!");
            }
            else
            {
                Console.WriteLine("Nooo, no 7 in the list!");
            }

            Console.ReadLine();
        }
    }
}