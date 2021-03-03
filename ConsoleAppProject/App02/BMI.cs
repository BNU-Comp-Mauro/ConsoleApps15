using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app serves as a BMI (Body Mass Index) calculator, by taking in height and weight as parameters.
    /// Values assigned according to WHO's standards.
    /// </summary>
    /// <author>
    /// Mauro Duarte Nunes
    /// 21815118
    /// 2/3/2021
    /// </author>
    public class BMI
    {
        public const int INCHES_IN_FEET = 12;

        public const int POUNDS_IN_STONES = 14;

        private double pounds;
        // As of making this app, making the stones and feet attributes private will lead the app to assume they are never used.
        public double stones;
        
        public double feet;

        private double inches;

        private double kilos;

        private double meters;

        private double bmi;
        public void Run()
        {
            OutputHeading();
            UnitChoice();
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("   Body Mass Index Calculator ");
            Console.WriteLine("        by Mauro Nunes        ");
            Console.WriteLine("-------------------------------");
        }
        private void UnitChoice()
        {
            Console.WriteLine("\nWhat units would you like to enter?");
            Console.WriteLine("\n1. Metric Units");
            Console.WriteLine("2. Imperial Units");
            Console.Write("\nPlease enter your choice > ");
            string choice = Console.ReadLine();
            if (choice.Equals("1"))
            {
                InputMeters();
                InputKilos();
                CalculateMetricBMI();
                OutputBMI();
                DisplayBAMEMessage();
            }
            else if (choice.Equals("2"))
            {
                InputFeet();
                InputInches();
                InputPounds();
                InputStones();
                CalculateImperialBMI();
                OutputBMI();
                DisplayBAMEMessage();
            }
            else
            {
                Console.WriteLine("\nPlease insert a valid option");
                UnitChoice();
            }
        }
        private void InputFeet()
        {
            Console.WriteLine("\nEnter your height to the nearest feet and inches");
            Console.Write("\nEnter your height in feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void InputInches()
        {
            Console.Write("Enter your height in inches > ");
            string value = Console.ReadLine();
            inches = Convert.ToDouble(value);
        }
        private void InputPounds()
        {
            Console.WriteLine("\nEnter your weight to the nearest stones and pounds");
            Console.Write("\nEnter your weight in stones > ");
            string value = Console.ReadLine();
            stones = Convert.ToDouble(value);
        }
        private void InputStones()
        {
            Console.Write("Enter your weight in pounds > ");
            string value = Console.ReadLine();
            pounds = Convert.ToDouble(value);
        }
        private void InputMeters()
        {
            Console.WriteLine("\nEnter your height to the nearest meters");
            Console.Write("Enter your height in meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }
        private void InputKilos()
        {
            Console.WriteLine("\nEnter your weight to the nearest kilograms");
            Console.Write("Enter your weight in kilograms > ");
            string value = Console.ReadLine();
            kilos = Convert.ToDouble(value);
        }
        private void CalculateMetricBMI()
        {
            bmi = kilos / ((meters) * (meters));
        }
        private void CalculateImperialBMI()
        {
            bmi = ((pounds + (stones * POUNDS_IN_STONES)) * 703) / ((inches + (feet * INCHES_IN_FEET)) * (inches + (feet * INCHES_IN_FEET)));
        }
        private void OutputBMI()
        {
            if (bmi < 18.50)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are the in the Underweight range!");
            }
            else if (bmi >= 18.50 && bmi < 25)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are in the Normal range!");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are in the Overweight range!");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are in the Obese I range!");
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are in the Obese II range!");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("\nYour BMI is " + bmi + ", you are in the Obese III range!");
            }
        }
        private void DisplayBAMEMessage()
        {
            Console.WriteLine("\nIf you are Black, Asian, or belong to another minority ethnic group, you have a higher risk.");
            Console.WriteLine("\nAdults 23.0 or more are at increased risk.");
            Console.WriteLine("Adults 27.5 or more are at high risk.");
        }
    }
}
