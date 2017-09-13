using System;

namespace _02_UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            // url = url.Replace("bots", "odds");
            // url = url.Insert(5, ":");

            // url = url.Replace("bots", "odds");
            // url = url.Replace("https", "https:");

            url = url.Replace("bots", "odds").Insert(5, ":");

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
