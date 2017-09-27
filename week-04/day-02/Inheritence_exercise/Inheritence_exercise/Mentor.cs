using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_exercise
{
    class Mentor : Person
    {
        public static readonly string[] LEVELS = new string[] { "junior", "intermediate", "senior" };

        string Level { get; set; }

        public Mentor(string name, int age, string gender, string level)
        {
            this.gender = gender;

            for (int i = 0; i < LEVELS.Length; i++)
            {
                if (level == LEVELS[i])
                {
                    Level = level;
                }
                else
                {
                    Level = "intermediate";
                }
            }
        }

        public Mentor()
        {
            Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", name, age, gender, Level);
        }
    }
}
