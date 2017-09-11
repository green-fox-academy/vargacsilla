using System;

namespace exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg;
            double heightInM;
            double BMI;

            Console.WriteLine("Hello! I will calculate your Body Mass Index, if you tell me your height and mass.");
            Console.WriteLine("Please type your mass in kg! (Only use numbers and , insted of . befora decimals!)");
            massInKg = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Please type your height in meters! (Only use numbers and , insted of . befora decimals!)");
            heightInM = double.Parse(Console.ReadLine());

            BMI = massInKg / (heightInM * heightInM);
            Console.WriteLine("If your mass is " + massInKg + " kg and your height is " + heightInM + " m, then your BMI = " + BMI + ".");
            Console.WriteLine("Press Enter to find out which weight category you belong to!");
            Console.ReadLine();

            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI is too low! Go, grab a hamburger NOW!");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Your BMI is in the good range, you're doing fine!");
            }
            else
            {
                Console.WriteLine("You are overweight. Go to the gym NOW!");
            }
            Console.ReadLine();
        }
    }
}
