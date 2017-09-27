using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_exercise
{
    class Sponsor : Person
    {
        public int HiredStudents { get; set; }

        string company;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.company = company;
        }

        public Sponsor()
        {
            company= "Google";
            HiredStudents = 0;
        }

        public void Hire()
        {
            HiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} company " +
                "and hired {4} students so far.", name, age, gender, company, HiredStudents);
        }
    }
}
