using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person mark = new Person("Mark", 46, "male");
            people.Add(mark);

            Person jane = new Person();
            people.Add(jane);
            jane.GetGoal();
            Console.WriteLine();

            Student john = new Student("Johnny", 20, "male", "BME");
            people.Add(john);
            john.GetGoal();
            Console.WriteLine();

            Student student = new Student();
            people.Add(student);
            student.GetGoal();
            Console.WriteLine();
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            Mentor mentor = new Mentor();
            people.Add(mentor);
            Sponsor sponsor = new Sponsor();
            Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }
            
            Console.WriteLine();

            foreach (Person item in people)
            {
                item.Introduce();
                item.GetGoal();
                Console.WriteLine();
            }
            
            Console.WriteLine();

            PallidaClass alpaga = new PallidaClass("Alpaga");
            alpaga.AddStudent(student);
            alpaga.AddStudent(john);
            alpaga.AddMentor(mentor);
            alpaga.AddMentor(gandhi);
            alpaga.Info();

            Student myStudent = new Student("Csilla", 26, "female", "MOME");
            myStudent.SkipDays(2);
            Console.WriteLine(myStudent.SkippedDays);
            Console.ReadLine();
        }
    }
}
