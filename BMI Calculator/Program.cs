using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: BMI Calculator");
            Console.WriteLine("We are going to calculate body mass index, but first, I need some information from you!!");

            double weight;
            double height;

            Console.WriteLine("Please enter your weight(lbs):");
            while (!Double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("Thank you! Please enter your height(inches):");
            while (!Double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Please enter a valid number");
            }

            double bmi = Math.Round(((weight / (height * height)) * 703), 1);

            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi}");
                Console.WriteLine("You are underweight, please consult a doctor");
            }
            else if (bmi > 25)
            {
                Console.WriteLine($"Your BMI is {bmi}");
                Console.WriteLine("You are overweight, please consult a doctor");
            }
            else 
            {
                Console.WriteLine($"Your BMI is {bmi}");
                Console.WriteLine("You are within the ideal weight range, nice work!");
            }

        }
    }
}
