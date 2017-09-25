using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost post1 = new BlogPost();

            post1.SetAuthorName("John Doe");
            post1.SetTitle("Lorem Ipsum");
            post1.SetText("Lorem ipsum dolor sit amet.");
            post1.SetPublicationsDate("2000.05.04.");

            BlogPost post2 = new BlogPost();
            post2.SetAuthorName("Tim Urban");
            post2.SetTitle("Wait but why");
            post2.SetText("A popular long-form, stick-figure-illustrated blog about almost everything.");
            post2.SetPublicationsDate("2010.10.10.");

            BlogPost post3 = new BlogPost();
            post3.SetAuthorName("William Turton");
            post3.SetTitle("One Engineer Is Trying to Get IBM to Reckon With Trump");
            post3.SetText("Daniel Hanley, a cybersecurity engineer at IBM, doesn’t " +
                "want to be the center of attention. When I asked to take his picture " +
                "outside one of IBM’s New York City offices, he told me that he wasn’t " +
                "really into the whole organizer profile thing.");
            post3.SetPublicationsDate("2017.03.28.");

            Console.WriteLine(post3.GetText());
            Console.ReadLine();
        }
    }
}
