using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_exercise
{
    class Student : Person
    {
        public int SkippedDays { get; set; } = 0;

        string previousOrganization;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.previousOrganization = previousOrganization;
        }

        public Student()
        {
            previousOrganization = "The School of Life";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior sofware developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.",
                name, age, gender, previousOrganization, SkippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
