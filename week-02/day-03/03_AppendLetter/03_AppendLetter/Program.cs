using System;
using System.Collections.Generic;

namespace _03_AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
                Console.Write(far[i] + " ");
            }
            Console.ReadLine();
        }
    }
}